using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IMapper _mapper;

        public CommentController(IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException();
        }

        [HttpGet]
        [HttpGet("{id}/", Name = "GetComment")]
        public ActionResult GetComment(int id, int? skip = null, int? take = null)
        {
            // TODO: Get real estates from repo
            return NoContent();
        }

        [HttpGet]
        [HttpGet("{username}/", Name = "GetCommentByUser")]
        public ActionResult GetComment(string userName, int? skip = null, int? take = null)
        {
            // TODO: Get real estates from repo
            return NoContent();
        }
    }
}
