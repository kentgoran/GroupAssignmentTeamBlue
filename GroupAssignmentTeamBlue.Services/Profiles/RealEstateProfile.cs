using AutoMapper;
using AutoMapper.Mappers;
using GroupAssignmentTeamBlue.Model;
using GroupAssignmentTeamBlue.Model.Enums;
using GroupAssignmentTeamBlue.Services.DtoModels;
using Microsoft.AspNetCore.Builder;
using System;
using System.Linq;

namespace GroupAssignmentTeamBlue.Services.Profiles
{
    public class RealEstateProfile : Profile
    {
        public RealEstateProfile()
        {
            CreateMap<RealEstate, RealEstateDetailsDto>()
                .ForMember(dto => dto.Type, opt => opt.MapFrom(source => nameof(source.Type)));
            CreateMap<RealEstateForCreationDto, RealEstate>();
        }
    }
}
