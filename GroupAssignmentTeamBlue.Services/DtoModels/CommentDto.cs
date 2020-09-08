﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.Services.DtoModels
{
    public class CommentDto
    {
        public Guid Id { get; set; }
        public UserDto User { get; set; }
        public string Content { get; set; }
        public DateTime TimeOfCreation { get; set; }
        public CommentDto ParentComment { get; set; }
    }
}
