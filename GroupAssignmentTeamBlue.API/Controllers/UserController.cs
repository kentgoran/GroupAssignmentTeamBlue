using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GroupAssignmentTeamBlue.API.ErrorService;
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
    /// <summary>
    /// Controller for Users
    /// </summary>
    [Route("api/[controller]s")]
    [ApiController]
    [Consumes("application/json")]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly UnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;

        /// <summary>
        /// Constructor, sets up the Controller
        /// </summary>
        /// <param name="mapper">AutoMapper to be injected</param>
        /// <param name="context">DbContext to be injected</param>
        /// <param name="userManager">UserManager to be injected</param>
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetUser(string userName)
        {
            var user = _unitOfWork.UserRepository.Get(userName);
            if(user == null)
            {
                return NotFound(new ApiErrorResponseBody()
                {
                    Succeded = false,
                    Errors = new List<ApiError>()
                    {
                        new ApiError()
                        {
                            Code = $"UserNotFound",
                            Description = $"Could not found a user with username {userName}"
                        }
                    }
                });
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> RateUser(RatingForCreationDto rating)
        {
            var ratedUser = _unitOfWork.UserRepository.Get(rating.UserId);
            if (ratedUser == null)
            {
                return NotFound(new ApiErrorResponseBody()
                {
                    Succeded = false,
                    Errors = new List<ApiError>()
                    {
                        new ApiError()
                        {
                            Code = $"UserNotFound",
                            Description = $"Could not found a user with id {rating.UserId}"
                        }
                    }
                });
            }

            var ratingUser = await _userManager.GetUserAsync(User);
            if(ratingUser.Id == ratedUser.Id)
            {
                return BadRequest(new ApiErrorResponseBody()
                {
                    Succeded = false,
                    Errors = new List<ApiError>()
                    {
                        new ApiError()
                        {
                            Code = $"IllicitRating",
                            Description = $"A user can't rate give a rating on themself"
                        }
                    }
                });
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
