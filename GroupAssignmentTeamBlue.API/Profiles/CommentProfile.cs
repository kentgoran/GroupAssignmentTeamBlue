using AutoMapper;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.Model;
using System;

namespace GroupAssignmentTeamBlue.API.Profiles
{
    public class CommentProfile : Profile
    {

        
        public CommentProfile()
        {
            CreateMap<Comment, CommentDto>()
                .ForMember(dto => dto.UserName, opt => opt.MapFrom(source => source.User.UserName));

            //Possible to map realestateId to RealEstate?
            CreateMap<CommentForCreationDto, Comment>()
                .ForMember(dto => dto.TimeOfCreation, 
                opt => opt.MapFrom(source => DateTime.UtcNow));
            
        }
    }
}
