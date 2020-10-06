using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using GroupAssignmentTeamBlue.API.ErrorService;
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(RealEstateDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiErrorResponseBody))]
        public IActionResult GetRealEstates(int skip = 0, int take = 10)
        { 
            if (skip < 0)
            {
                ApiErrorResponseBody errorResponse = new ApiErrorResponseBody(false);
                errorResponse.AddError("Skip", new string[] { "Skip cannot be negative" });
                return BadRequest(errorResponse);
            }
            if (take < 1 || take > 100)
            {
                ApiErrorResponseBody errorResponse = new ApiErrorResponseBody(false);
                errorResponse.AddError("Take", new string[] { "Take needs to be a number between 1-100" });
                return BadRequest(errorResponse);
            }

            var realEstateEntities = _unitOfWork.RealEstateRepository
                .SkipAndTakeRealEstates(skip, take);
            var realEstateDtos = _mapper.Map<IEnumerable<RealEstateDto>>(realEstateEntities);
            return Ok(realEstateDtos);
        }

        /// <summary>
        /// GET for the number of real estates.
        /// </summary>
        /// <returns>Number of real estates.</returns>
        [HttpGet("count")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        public IActionResult GetRealEstateCount()
        {
            return Ok(_unitOfWork.RealEstateRepository.GetRealEstateCount());
        }

        /// <summary>
        /// GET for a single RealEstate, by RealEstateId. If user is authenticated, it returns full details, else a dto with less details
        /// </summary>
        /// <param name="id">Id of the RealEstate to get</param>
        /// <returns>a RealEstate, with details corresponding to if the user is logged in or not</returns>
        [HttpGet("{id}", Name = "GetRealEstate")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(RealEstateFullDetailDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiErrorResponseBody))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiErrorResponseBody))]
        public ActionResult GetRealEstate(int id)
        {
            var realEstateEntity = _unitOfWork.RealEstateRepository.GetWithIncludes(id);
            if (realEstateEntity == null)
            {
                ApiErrorResponseBody errorResponse = new ApiErrorResponseBody(false);
                errorResponse.AddError("RealEstate", new string[] { $"Could not find a Real Estate with id {id}" });
                return NotFound(errorResponse);
            }

            //If the user is logged in, returns the fully detailed RealEstate, else returns less detailed data
            var realEstateDto = User.Identity.IsAuthenticated ?
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
            //Pictures aren't mapped automatically, so made manually
            realEstateToAdd.Pictures = ConvertToPictures(realEstate.Urls);

            var user = await _userManager.GetUserAsync(User);
            realEstateToAdd.User = user;
            _unitOfWork.RealEstateRepository.Add(realEstateToAdd);
            _unitOfWork.SaveChanges();

            var realEstateForReturn = _mapper.Map<RealEstateDto>(realEstateToAdd);
            return CreatedAtRoute("GetRealEstate", new { id = realEstateForReturn.Id }, realEstateForReturn);
        }

        /// <summary>
        /// Converts an IEnumerable of strings into an IEnumerable of Pictures
        /// </summary>
        /// <param name="stringUrls"></param>
        /// <returns></returns>
        private IEnumerable<Picture> ConvertToPictures(IEnumerable<string> stringUrls)
        {
            var toReturn = new List<Picture>();
            foreach(var url in stringUrls)
            {
                toReturn.Add(new Picture()
                {
                    Url = url
                });
            }
            return toReturn;
        }
    }
}
