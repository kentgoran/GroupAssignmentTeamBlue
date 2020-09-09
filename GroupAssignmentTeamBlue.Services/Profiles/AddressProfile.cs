using AutoMapper;
using GroupAssignmentTeamBlue.Model;
using GroupAssignmentTeamBlue.Services.DtoModels;

namespace GroupAssignmentTeamBlue.Services.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, AddressDto>();

        }
    }
}
