using AutoMapper;
using GroupAssignmentTeamBlue.Model;
using GroupAssignmentTeamBlue.Services.DtoModels;

namespace GroupAssignmentTeamBlue.Services.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<UserForCreationDto, User>();
        }

    }
}
