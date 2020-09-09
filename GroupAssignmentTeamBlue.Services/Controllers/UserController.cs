using AutoMapper;
using GroupAssignmentTeamBlue.DAL.Repositories;
using GroupAssignmentTeamBlue.Model;
using GroupAssignmentTeamBlue.Services.DtoModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.Services.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IRepository<User> _repository;
        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException();
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserDto>> GetUsers()
        {
            // TODO: Get users from repo
            return NoContent();
        }

        [HttpGet("{id}", Name = "GetUser")]
        public IActionResult GetUser(int userId)
        {
            // TODO: Get user from repo
            return NoContent();
        }

        [HttpPost]
        public IActionResult CreateUser(UserForCreationDto user)
        {
            // TODO: Add user to db
            return NoContent();
        }
    }
}
