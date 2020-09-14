using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.DAL.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GroupAssignmentTeamBlue.API.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class RealEstateController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly UnitOfWork _unitOfWork;

        public RealEstateController(IMapper mapper, AdvertContext context)
        {
            _mapper = mapper ?? throw new ArgumentNullException();
            _unitOfWork = context == null ? 
                            throw new ArgumentNullException() : new UnitOfWork(context);
        }

        [HttpGet]
        public IActionResult GetRealEstates(int skip = 0, int take = 10)
        {
            if (take == 0 || take > 100)
            {
                return BadRequest();                
            }

            var realEstateEntities = _unitOfWork.RealEstateRepository.SkipAndTakeRealEstates(skip, take);
            var realEstateDtos = _mapper.Map<IEnumerable<RealEstateDto>>(realEstateEntities);
            return Ok(realEstateDtos);
        }

        // Det här? ...
        [HttpGet("{id}/", Name = "GetRealEstate")]
        public ActionResult GetRealEstate(int realEstateId)
        {
            var realEstateEntity = _unitOfWork.RealEstateRepository.Get(realEstateId);
            if(realEstateEntity == null)
            {
                return NotFound();
            }

            RealEstateDto realEstateDto = null;
            if (User.Identity.IsAuthenticated)
            {
                realEstateDto = _mapper.Map<RealEstatePartlyDetailedDto>(realEstateEntity);
            }
            else
            {
                realEstateDto = _mapper.Map<RealEstatePartlyDetailedDto>(realEstateEntity);
            }
            return Ok(realEstateDto);
        }


            // ... eller det här vv ?
        /*
        [HttpGet("{id}/", Name = "GetRealEstate")]
        public ActionResult GetRealEstate(int realEstateId)
        {
            var realEstateEntity = _unitOfWork.RealEstateRepository.Get(realEstateId);

            if (realEstateEntity == null)
            {
                return NotFound();
            }
            var realEstateDto = _mapper.Map<RealEstatePartlyDetailedDto>(realEstateEntity);
            return Ok(realEstateDto);
        }

        [Authorize]
        [HttpGet("{id}/", Name = "GetRealEstate")]
        public ActionResult GetRealEstateDetails(int realEstateId)
        {
            var realEstateEntity = _unitOfWork.RealEstateRepository.Get(realEstateId);

            if(realEstateEntity == null)
            {
                return NotFound();
            }
            var realEstateDto = _mapper.Map<RealEstateFullDetailDto>(realEstateEntity);
            return Ok(realEstateDto);
        }
        */
    }
}
