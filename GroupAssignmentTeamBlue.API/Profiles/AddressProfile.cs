using AutoMapper;
using GroupAssignmentTeamBlue.Model;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using System.Text.RegularExpressions;

namespace GroupAssignmentTeamBlue.API.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, AddressDto>();
            CreateMap<AddressDto, Address>();
            CreateMap<AddressForCreationDto, Address>();
        }
    }
}
