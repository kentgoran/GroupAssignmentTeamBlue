using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GroupAssignmentTeamBlue.API.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly UnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;

        public UserController(IMapper mapper, AdvertContext context, UserManager<User> userManager)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _unitOfWork = context == null ? 
                throw new ArgumentNullException(nameof(context)) :
                new UnitOfWork(context);
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
        }

        /// <summary>
        /// Gets a user with the given username from the repository.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns> Returns a 200 Ok together with a representatino of the user if the entity was found.
        /// If no entity with the given username was found a status code of 404 Not Found is returned.</returns>
        [HttpGet("{userName}/", Name = "GetUser")]
        public ActionResult GetUser(string userName)
        {
            var user = _unitOfWork.UserRepository.Get(userName);
            if(user == null)
            {
                return NotFound("No user with the given username was found");
            }

            var userForReturn = _mapper.Map<UserDto>(user);

            return Ok(userForReturn);
        }

        /// <summary>
        /// Creates a rating if no record with corelating rating- and rated-user was found, 
        /// else it updates the existing record.
        /// </summary>
        /// <param name="rating"></param>
        /// <returns> Returns a status code of 200 OK if the records was updated or created. 
        /// If no user with the given id was found a status code of 404 Not Found is returned.</returns>
        [Authorize]
        [HttpPut("rate/")]
        public async Task<ActionResult> RateUser(RatingForCreationDto rating)
        {
            var ratedUser = _unitOfWork.UserRepository.Get(rating.UserId);
            if (ratedUser == null)
            {
                return NotFound("User could not be found");
            }

            var ratingUser = await _userManager.GetUserAsync(User);
            if(ratingUser.Id == ratedUser.Id)
            {
                return BadRequest("You can't rate yourself");
            }

            var foundRating = _unitOfWork.RatingRepository.Get(ratedUser.Id, ratingUser.Id);
            if(foundRating == null)
            {
                var ratingToAdd = _mapper.Map<Rating>(rating);
                ratingToAdd.RatingUserId = ratingUser.Id;
                _unitOfWork.RatingRepository.Add(ratingToAdd);
            }
            else
            {
                foundRating.Score = rating.Value;
            }

            _unitOfWork.SaveChanges();

            return Ok();
        }
    }
}
