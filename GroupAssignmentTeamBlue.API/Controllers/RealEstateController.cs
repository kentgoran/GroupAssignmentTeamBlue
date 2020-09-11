using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GroupAssignmentTeamBlue.API.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class RealEstateController : ControllerBase
    {
        private readonly IMapper _mapper;

        public RealEstateController(IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException();
        }

        [HttpGet]
        public ActionResult GetRealEstates(int? skip = null, int? take = null)
        {
            // TODO: Get real estates from repo
            return NoContent();
        }

        [HttpGet("{id}/", Name = "GetRealEstate")]
        public ActionResult GetRealEstate(int userId)
        {
            // TODO: Get real estate from repo
            return NoContent();
        }
    }
}
