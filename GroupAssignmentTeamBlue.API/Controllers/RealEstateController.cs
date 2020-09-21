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
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GroupAssignmentTeamBlue.API.Controllers
{
    /// <summary>
    /// Controller for RealEstates
    /// </summary>
    [Route("api/[controller]s")]
    [ApiController]
    [Consumes("application/json")]
    public class RealEstateController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly UnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;

        /// <summary>
        /// Constructor, sets up the controller
        /// </summary>
        /// <param name="mapper">AutoMapper to be injected</param>
        /// <param name="context">DbContext to be injected</param>
        /// <param name="userManager">UserManager to be injected</param>
        public RealEstateController(IMapper mapper, AdvertContext context, UserManager<User> userManager)
        {
            _mapper = mapper ?? throw new ArgumentNullException();
            _unitOfWork = context == null ? 
                            throw new ArgumentNullException() : new UnitOfWork(context);
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
        }

        /// <summary>
        /// GET for RealEstates, with optional skip/take parameters for paging, does not require authentication
        /// </summary>
        /// <param name="skip">Amount to skip, can't be negative number. default = 0</param>
        /// <param name="take">Amount to take, has to be 1-100. default = 10</param>
        /// <returns>A list of RealEstates present, BadRequest if skip/take is invalid numbers</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetRealEstates(int skip = 0, int take = 10)
        {
            if (skip < 0)
            {
                return BadRequest("Skip can't be a negative number");
            }
            if (take < 1 || take > 100)
            {
                return BadRequest("Take must be 1-100");
            }

            var realEstateEntities = _unitOfWork.RealEstateRepository
                .SkipAndTakeRealEstates(skip, take);
            var realEstateDtos = _mapper.Map<IEnumerable<RealEstateDto>>(realEstateEntities);
            return Ok(realEstateDtos);
        }

        /// <summary>
        /// GET for a single RealEstate, by RealEstateId. If user is authenticated, it returns full details, else a dto with less details
        /// </summary>
        /// <param name="id">Id of the RealEstate to get</param>
        /// <returns>a RealEstate, with details corresponding to if the user is logged in or not</returns>
        [HttpGet("{id}", Name = "GetRealEstate")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetRealEstate(int id)
        {
            var realEstateEntity = _unitOfWork.RealEstateRepository.GetAndIncludeComments(id);
            if (realEstateEntity == null)
            {
                return NotFound($"RealEstate with id {id} not found");
            }

            //If the user is logged in, returns the fully detailed RealEstate, else returns less detailed data
            RealEstateDto realEstateDto = User.Identity.IsAuthenticated ?
                _mapper.Map<RealEstateFullDetailDto>(realEstateEntity) :
                _mapper.Map<RealEstatePartlyDetailedDto>(realEstateEntity);

            return Ok(realEstateDto);
        }

        /// <summary>
        /// POST action for RealEstate. Creates a new RealEstate. Requires authentication
        /// </summary>
        /// <param name="realEstate">Contains all the information needed to create a new RealEstate</param>
        /// <returns>201 Created, with some of the info input</returns>
        [Authorize]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CreateRealEstate(RealEstateForCreationDto realEstate)
        {
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
