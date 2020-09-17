using AutoMapper;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Controllers
{
    [Authorize]
    [Route("api/[controller]s")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly UnitOfWork _unitOfWork;

        public CommentController(IMapper mapper, AdvertContext context, UserManager<User> userManager)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            else
            {
                _unitOfWork = new UnitOfWork(context);
            }
        }

        /// <summary>
        /// GET Method for getting comments based on the realEstate they were written for, with skip and take for paging-functionality
        /// </summary>
        /// <param name="id">id-number to the realEstate in question</param>
        /// <param name="skip">Optional number for comments to skip, default is 0</param>
        /// <param name="take">optional number for comments to take, default is 10, max is 100</param>
        /// <returns>All comments wanted</returns>
        [HttpGet]
        [HttpGet("{id}/", Name = "GetComment")]
        public ActionResult GetComment(int id, int skip = 0, int take = 10)
        {
            if(skip < 0)
            {
                return BadRequest("Skip can't be a negative number");
            }
            if(take < 1 || take > 100)
            {
                return BadRequest("Take must be 1-100");
            }
            if (!_unitOfWork.RealEstateRepository.EntityExists(id))
            {
                return NotFound($"Real Estate Id {id} was not found.");
            }

            var comments = _unitOfWork.CommentRepository.GetCommentsForRealEstate(id, skip, take);
            var toReturn = _mapper.Map<List<CommentDto>>(comments);
            
            return Ok(toReturn);
        }

        /// <summary>
        /// Gets comments made by a given user, by username
        /// </summary>
        /// <param name="username">The user from where to get comments</param>
        /// <param name="skip">The amount of comments to skip, default = 0</param>
        /// <param name="take">The amount of comments to take, default = 10</param>
        /// <returns>200 OK, with a list of comments</returns>
        [HttpGet]
        [HttpGet("byuser/{username}/", Name = "GetCommentByUser")]
        public ActionResult GetComment(string username, int skip = 0, int take = 10)
        {
            if (skip < 0)
            {
                return BadRequest("Skip can't be a negative number");
            }
            if (take < 1 || take > 100)
            {
                return BadRequest("Take must be 1-100");
            }
            if(_unitOfWork.UserRepository.Get(username) == null)
            {
                return NotFound($"Username '{username}' was not found");
            }

            var comments = _unitOfWork.CommentRepository.GetCommentsByUser(username, skip, take);
            var toReturn = _mapper.Map<List<CommentDto>>(comments);

            return Ok(toReturn);
        }

        /// <summary>
        /// POST for a new comment
        /// </summary>
        /// <param name="commentForCreation">Information about the comment to be created</param>
        /// <returns>200 OK with comment content, username and creation-time. BadRequest if RealEstate is not found</returns>
        [HttpPost]
        public ActionResult PostComment(CommentForCreationDto commentForCreation)
        {
            //Gets username from the token
            var username = HttpContext.User.Identity.Name;
            var comment = _mapper.Map<Comment>(commentForCreation);

            //Check if the realestate-id maps to an actual entity
            if(!_unitOfWork.RealEstateRepository.EntityExists(comment.RealEstateId))
            {
                return NotFound($"RealEstate with id {comment.RealEstateId} was not found");
            }

            //get current users Id, and adds it to the new comment
            comment.UserId = _unitOfWork.UserRepository.Get(username).Id;
            
            _unitOfWork.CommentRepository.Add(comment);
            _unitOfWork.SaveChanges();

            return Ok(new 
            {
                comment.Content,
                username,
                CreatedOn = comment.TimeOfCreation
            });
        }
    }
}
