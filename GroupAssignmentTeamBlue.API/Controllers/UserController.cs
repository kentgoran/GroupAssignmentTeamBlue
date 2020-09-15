using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.Model;
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

        [HttpGet("{userName}/", Name = "GetUser")]
        public ActionResult GetUser(string userName)
        {
                 // needs to be get by username instead of by id
            //_unitOfWork.UserRepository.Get();
            // TODO: Get user from repo
            return NoContent();
        }

        
        [HttpPut("rate/")]
        public async Task<ActionResult> RateUser(RatingForCreationDto rating)
        {
            // TODO: check if rated user and rating already have a rating.
            /*
            if(_unitOfWork.RatingRepository.EntityExists(ratedUser, ratingUser))
            {

            }
            */

            var ratingToAdd = _mapper.Map<Rating>(rating);
            var ratedUser = _unitOfWork.UserRepository.Get(rating.RatedUserId);
            var ratingUser = await _userManager.GetUserAsync(User);

            ratingToAdd.RatedUser = ratedUser;
            ratingToAdd.RatingUser = ratingUser;
            
            _unitOfWork.RatingRepository.Add(ratingToAdd);
            _unitOfWork.SaveChanges();

            return Ok();
        }
    }
}
