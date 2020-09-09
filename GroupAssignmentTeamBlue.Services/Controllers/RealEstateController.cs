using AutoMapper;
using GroupAssignmentTeamBlue.DAL.Repositories;
using GroupAssignmentTeamBlue.Model;
using GroupAssignmentTeamBlue.Services.DtoModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;
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
        private readonly IRepository<RealEstate> _repository;
        private readonly IMapper _mapper;

        /*
        public RealEstateController(IRepository<RealEstate> repository, IMapper mapper)
        {
            _repository = repository ?? throw new NullReferenceException();
            _mapper = mapper ?? throw new ArgumentNullException();
        }
        */
        public RealEstateController(IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException();
        }


        [HttpGet]
        public ActionResult GetRealEstates()
        {
            // TODO: Get top 10 realestates from repo
            // TODO: Paging??
            return NoContent();
        }

        [HttpGet("{id}", Name = "GetRealEstate")]
        public ActionResult GetRealEstate(int realEstateId)
        {
            // TODO: Check if user is logged in
            /*
            var realEstateEntity =_repository.Get(realEstateId);
            if(realEstateEntity == null)
            {
                return NotFound();
            }

            var realestateToRetur = _mapper.Map<RealEstateDetailsDto>(realEstateEntity);
            */

            return NoContent();
        }

        [HttpPost]
        public ActionResult CreateRealEstate(RealEstateForCreationDto realEstate)
        {

            //_repository.Add();
            // TODO: Check if resources exists
            // TODO: Create estate in repo

            // Ska date of creation sättas här eller i repo?

            // map test vv
            var estateToSave = _mapper.Map<RealEstate>(realEstate);
            var estateToReturn = _mapper.Map<RealEstateDetailsDto>(estateToSave);

            return Ok(estateToReturn);
        }
    }
}
