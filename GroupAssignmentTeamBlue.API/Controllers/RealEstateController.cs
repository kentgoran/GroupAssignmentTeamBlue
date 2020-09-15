using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.DAL.Repositories;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GroupAssignmentTeamBlue.API.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class RealEstateController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly UnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;

        public RealEstateController(IMapper mapper, AdvertContext context, UserManager<User> userManager)
        {
            _mapper = mapper ?? throw new ArgumentNullException();
            _unitOfWork = context == null ? 
                            throw new ArgumentNullException() : new UnitOfWork(context);
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
        }

        [HttpGet]
        public IActionResult GetRealEstates(int skip = 0, int take = 10)
        {
            if (take <= 0 || take > 100)
            {
                return BadRequest();                
            }

            var realEstateEntities = _unitOfWork.RealEstateRepository
                .SkipAndTakeRealEstates(skip, take).OrderByDescending(re => re.DateOfAdvertCreation);
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

            realEstateDto = User.Identity.IsAuthenticated ?
                _mapper.Map<RealEstateFullDetailDto>(realEstateEntity) : 
                _mapper.Map<RealEstatePartlyDetailedDto>(realEstateEntity);

            // If the user is logged in/ authenticated 
            if (User.Identity.IsAuthenticated)
            {
                // Creates a map of the real estate with all details included
                realEstateDto = _mapper.Map<RealEstateFullDetailDto>(realEstateEntity);
            }
            else
            {
                // Creates a map of the real estate with some details included
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

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateRealEstate(RealEstateForCreationDto realEstate)
        {
            //User.Identity.Name?
            var realEstateToAdd = _mapper.Map<RealEstate>(realEstate);

            var user = await _userManager.GetUserAsync(User);
            realEstateToAdd.User = user;
            _unitOfWork.RealEstateRepository.Add(realEstateToAdd);
            _unitOfWork.SaveChanges();

            var realEstateForReturn = _mapper.Map<RealEstateDto>(realEstateToAdd);
            return CreatedAtRoute("GetRealEstate", new { id = realEstateForReturn.Id }, realEstateForReturn);
        }
    }
}
