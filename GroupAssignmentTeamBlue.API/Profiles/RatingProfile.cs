using AutoMapper;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Profiles
{
    public class RatingProfile : Profile
    {


        public RatingProfile()
        {
            CreateMap<RatingForCreationDto, Rating>()
                .ForMember(dto => dto.RatedUserId, opt => opt.MapFrom(source => source.UserId))
                .ForMember(dto => dto.Score, opt => opt.MapFrom(source => source.Value));
        }
    }
}
