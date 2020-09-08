using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.Services.Controllers
{
    [ApiController]
    [Route("api/realetates")]
    public class RealEstateController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetRealEstates()
        {
            // TODO: Get real estates from repo
            return NoContent();
        }

        [HttpGet("{id}", Name = "GetRealEstate")]
        public ActionResult GetRealEstate(Guid userId)
        {
            // TODO: Get real estate from repo
            return NoContent();
        }
    }
}
