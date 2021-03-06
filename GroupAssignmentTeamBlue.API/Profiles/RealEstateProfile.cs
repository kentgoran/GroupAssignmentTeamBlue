﻿using AutoMapper;
using AutoMapper.Configuration.Annotations;
using AutoMapper.Mappers;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.Model;
using GroupAssignmentTeamBlue.Model.Enums;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.JSInterop.Infrastructure;
using System;
using System.Linq;

namespace GroupAssignmentTeamBlue.API.Profiles
{
    /// <summary>
    /// Profiler for RealEstates
    /// </summary>
    public class RealEstateProfile : Profile
    {
        /// <summary>
        /// Constructor, setting up mapping for using AutoMapper on RealEstates and their Dto's
        /// </summary>
        public RealEstateProfile()
        {

            CreateMap<RealEstate, RealEstateDto>()
                .ForMember(dto => dto.RealEstateType, opt => opt.MapFrom(source => (int)source.Type));

            CreateMap<RealEstate, RealEstateFullDetailDto>()
                .ForMember(dto => dto.Comments, opt => opt.MapFrom(source => source.Comments))
                .ForMember(dto => dto.Urls, opt => opt.MapFrom(source => source.Pictures))
                .ForMember(dto => dto.UserName, opt => opt.MapFrom(source => source.User.UserName));

            //.ForMember(dto => dto.Address, 
            //opt => opt.MapFrom(source => $"{source.Address.StreetName} {source.Address.StreetNumber}"));

            CreateMap<RealEstate, RealEstateNoAuthDetailDto>()
                .ForMember(dto => dto.RealEstateType, opt => opt.MapFrom(source => (int)source.Type))
                .ForMember(dto => dto.Urls, opt => opt.MapFrom(source => source.Pictures));

            CreateMap<RealEstateForCreationDto, RealEstate>()
                .ForMember(entity => entity.IsSellable,
                opt => opt.MapFrom(source => source.SellingPrice == null ? false : true))
                .ForMember(entity => entity.IsRentable,
                opt => opt.MapFrom(source => source.RentingPrice == null ? false : true))
                .ForMember(entity => entity.SellPrice, opt => opt.MapFrom(source => source.SellingPrice))
                .ForMember(entity => entity.Rent, opt => opt.MapFrom(source => source.RentingPrice))
                .ForMember(entity => entity.DateOfAdvertCreation, opt => opt.MapFrom(source => DateTime.UtcNow));
        }
    }
}
