using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GroupAssignmentTeamBlue.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException();
        }

        [HttpGet]
        public ActionResult GetUsers()
        {
            // TODO: Get users from repo
            return NoContent();
        }

        [HttpGet("{username}/", Name = "GetUser")]
        public ActionResult GetUser(string userName)
        {
            // TODO: Get user from repo
            return NoContent();
        }

        /*
        [HttpPut("Rate/")]
        public ActionResult GetUser(int userId)
        {
            // TODO: Get user from repo
            return NoContent();
        }
        */
    }
}
