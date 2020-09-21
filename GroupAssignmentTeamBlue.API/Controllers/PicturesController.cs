﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.Model;
using AutoMapper;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using Microsoft.AspNetCore.Authorization;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;

namespace GroupAssignmentTeamBlue.API.Controllers
{
    /// <summary>
    /// Controller for GET/POST/DELETE of pictures
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PicturesController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor for PicturesController
        /// </summary>
        /// <param name="context">Dbcontext to be injected</param>
        /// <param name="mapper">Mapper to be injected</param>
        public PicturesController(AdvertContext context, IMapper mapper)
        {
            _unitOfWork = context == null ? throw new ArgumentNullException(nameof(context)) : new UnitOfWork(context);
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// GET method to get pictures for a given realEstate, by Id
        /// </summary>
        /// <param name="id">Id of the realEstate</param>
        /// <returns>200 OK with a list of pictures</returns>
        [HttpGet("{id}/", Name = "GetPicsForRealEstate")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetPicsForRealEstate(int id)
        {
            if (!_unitOfWork.RealEstateRepository.EntityExists(id))
            {
                return NotFound();
            }
            var pictures = _unitOfWork.PictureRepository.GetAllPicturesForRealEstate(id).ToList();
            var mappedPictures = _mapper.Map<List<PictureDto>>(pictures);
            return Ok(mappedPictures);
        }

        /// <summary>
        /// POST method for creating a new picture, linked to given realEstate
        /// </summary>
        /// <param name="picture">Url and realEstateId</param>
        /// <returns>201 Created, and the url attained together with id of the realestate</returns>
        [Authorize]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult PostPic(PictureForCreationDto picture)
        {
            if (!_unitOfWork.RealEstateRepository.EntityExists(picture.RealEstateId))
            {
                return NotFound($"RealEstate with id {picture.RealEstateId} was not found");
            }
            var picToAdd = _mapper.Map<Picture>(picture);
            var picToReturn = _mapper.Map<PictureDto>(picture);
            _unitOfWork.PictureRepository.Add(picToAdd);
            _unitOfWork.SaveChanges();
            //test if this works
            //also, return picToAdd instead? or pictureId is irrelevant?
            return CreatedAtAction("GetPicsForRealEstate", new { picToAdd.Url }, picToReturn);
        }
    }
}
