using AutoMapper;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.Model;
using System.Linq;

namespace GroupAssignmentTeamBlue.API.Profiles
{
    /// <summary>
    /// Profiler for setting up AutoMapper on Users and their Dto's
    /// </summary>
    public class UserProfile : Profile
    {
        /// <summary>
        /// Constructor, setting up mapping for using AutoMapper on User and it's Dto's
        /// </summary>
        public UserProfile()
        {
            CreateMap<User, UserDto>()                                              // Prestanda problem??
                .ForMember(dto => dto.RealEstateCount, opt => opt.MapFrom(source => source.RealEstates.Count()))
                .ForMember(dto => dto.CommentCount, opt => opt.MapFrom(source => source.Comments.Count()))
                //If user has 0 ratings recieved, return 0, else return average rating recieved
                .ForMember(dto => dto.RatingAvrage, opt => opt.MapFrom(source => source.RatingsRecieved.Count() == 0 ? 0 : source.RatingsRecieved.Select(r => r.Score).Average()));
            CreateMap<UserDto, User>();
            CreateMap<UserForCreationDto, User>();
        }

    }
}
