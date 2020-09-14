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

        [HttpGet]
        [HttpGet("{id}/", Name = "GetComment")]
        public ActionResult GetComment(int id, int skip = 0, int take = 10)
        {
            if(take > 100)
            {
                return BadRequest("Cannot take more than 100 items at a time");
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
