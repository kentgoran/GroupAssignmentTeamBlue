using AutoMapper;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.Model;
using System;

namespace GroupAssignmentTeamBlue.API.Profiles
{
    /// <summary>
    /// Profiler for using AutoMapper with Comments
    /// </summary>
    public class CommentProfile : Profile
    {

        /// <summary>
        /// Constructor for CommentProfile, setting mapping for Comments and it's dto's
        /// </summary>
        public CommentProfile()
        {
            CreateMap<Comment, CommentDto>()
                .ForMember(dto => dto.UserName, opt => opt.MapFrom(source => source.User.UserName));

            CreateMap<CommentForCreationDto, Comment>()
                .ForMember(dto => dto.TimeOfCreation, 
                opt => opt.MapFrom(source => DateTime.UtcNow));
            
        }
    }
}
