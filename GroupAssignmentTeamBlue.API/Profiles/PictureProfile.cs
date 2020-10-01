using AutoMapper;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Profiles
{
    /// <summary>
    /// Profile for mapping Picture with it's dto's
    /// </summary>
    public class PictureProfile : Profile
    {
        /// <summary>
        /// Constructor, adds the different profiles
        /// </summary>
        public PictureProfile()
        {
            CreateMap<Picture, PictureDto>();
        }
    }
}
