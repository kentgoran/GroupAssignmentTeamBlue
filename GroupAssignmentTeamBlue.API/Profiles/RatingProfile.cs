﻿using AutoMapper;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Profiles
{
    /// <summary>
    /// Profiler for using AutoMapper on Ratings and it's dto's
    /// </summary>
    public class RatingProfile : Profile
    {

        /// <summary>
        /// Constructor, setting up AutoMapper for Ratings and it's dto's
        /// </summary>
        public RatingProfile()
        {
            CreateMap<RatingForCreationDto, Rating>()
                .ForMember(dto => dto.Score, opt => opt.MapFrom(source => source.Value));
        }
    }
}
