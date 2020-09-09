using AutoMapper;
using AutoMapper.Configuration.Annotations;
using AutoMapper.Mappers;
using GroupAssignmentTeamBlue.Model;
using GroupAssignmentTeamBlue.Model.Enums;
using GroupAssignmentTeamBlue.Services.DtoModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.JSInterop.Infrastructure;
using System;
using System.Linq;

namespace GroupAssignmentTeamBlue.Services.Profiles
{
    public class RealEstateProfile : Profile
    {
        public RealEstateProfile()
        {
            CreateMap<RealEstate, RealEstateDetailsDto>()
                .ForMember(dto => dto.Type, opt => opt.MapFrom(source => source.Type.ToString()));

            CreateMap<RealEstateForCreationDto, RealEstate>();
        }
    }
}
