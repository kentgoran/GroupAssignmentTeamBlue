using GroupAssignmentTeamBlue.Services.DtoModels;
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
        public ActionResult GetRealEstate(Guid realEstateId)
        {
            // TODO: Get real estate from repo
            return NoContent();
        }

        [HttpPost]
        public ActionResult GetRealEstate(RealEstateForCreationDto realEstate)
        {
            // TODO: Check if resources exists
            // TODO: Get create estate in repo
            return NoContent();
        }
    }
}
