using AutoMapper;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.Model;
using System.Linq;

namespace GroupAssignmentTeamBlue.API.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>()                                              // Prestanda problem??
                .ForMember(dto => dto.RealEstateCount, opt => opt.MapFrom(source => source.RealEstates.Count()))
                .ForMember(dto => dto.CommentCount, opt => opt.MapFrom(source => source.Comments.Count()))
                .ForMember(dto => dto.RatingAvrage, opt => opt.MapFrom(source => source.RatingsRecieved.Select(r => r.Score).Average()));
            CreateMap<UserDto, User>();
            CreateMap<UserForCreationDto, User>();
        }

    }
}
