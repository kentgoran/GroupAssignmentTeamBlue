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
        /// 
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
            var comments = _unitOfWork.CommentRepository.GetCommentsForRealEstate(id, skip, take);
            //Does this work? or map each one individually?
            var toReturn = _mapper.Map<List<CommentDto>>(comments);
            

            return Ok(toReturn);
        }


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
        public async Task<ActionResult> PostComment(CommentForCreationDto commentForCreation)
        {
            var username = HttpContext.User.Identity.Name;
            var comment = _mapper.Map<Comment>(commentForCreation);
            //TODO: Change below logic to the mapper profile, if possible
            comment.RealEstateInQuestion = _unitOfWork.RealEstateRepository.Get(commentForCreation.RealEstateId);

            if(comment.RealEstateInQuestion == null)
            {
                return BadRequest($"RealEstate with id {commentForCreation.RealEstateId} was not found");
            }
            comment.User = await _userManager.FindByNameAsync(username);
            
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
