using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels
{
    public class CommentDto
    {
        public string UserName { get; set; }
        public string Content { get; set; }
        public DateTime TimeOfCreation { get; set; }
        public CommentDto ParentComment { get; set; }
    }
}
