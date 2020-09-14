using AutoMapper;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.DAL.Context;
using Microsoft.AspNetCore.Authorization;
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
        private readonly UnitOfWork _unitOfWork;

        public CommentController(IMapper mapper, AdvertContext context)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
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
        public ActionResult GetComment(string userName, int? skip = null, int? take = null)
        {
            // TODO: Get comment by user from repo
            return NoContent();
        }
    }
}
