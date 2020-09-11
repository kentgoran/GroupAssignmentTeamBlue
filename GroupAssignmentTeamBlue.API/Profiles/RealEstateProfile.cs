using AutoMapper;
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
    public class RealEstateProfile : Profile
    {
        public RealEstateProfile()
        {
            CreateMap<RealEstate, RealEstateDto>();

            // Måste testas!!
            CreateMap<RealEstate, RealEstateFullDetailDto>();
                //.ForMember(dto => dto.Address, 
                //opt => opt.MapFrom(source => $"{source.Address.StreetName} {source.Address.StreetNumber}"));

            CreateMap<RealEstate, RealEstatePartlyDetailedDto>()
                .ForMember(dto => dto.Type, opt => opt.MapFrom(source => source.Type.ToString()))
                .ForMember(dto => dto.Address
                , opt => opt.MapFrom(source => $"{source.Address.StreetName} {source.Address.StreetNumber}"))
                .ForMember(dto => dto.Type, opt => opt.MapFrom(source => nameof(source.Type)));

            CreateMap<RealEstateForCreationDto, RealEstate>();
        }
    }
}
