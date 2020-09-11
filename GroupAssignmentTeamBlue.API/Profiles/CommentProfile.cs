using AutoMapper;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.Model;

namespace GroupAssignmentTeamBlue.API.Profiles
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<Comment, CommentDto>()
                .ForMember(dto => dto.UserName, opt => opt.MapFrom(source => source.User.UserName));

            CreateMap<CommentForCreationDto, Comment>();
        }
    }
}
