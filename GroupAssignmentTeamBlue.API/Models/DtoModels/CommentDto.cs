using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels
{
    /// <summary>
    /// Comment dto, contains username, Content, Time of creation and Parent comment
    /// </summary>
    public class CommentDto
    {
        /// <summary>
        /// Username of the person who placed the comment
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// The actual comment
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// When the comment was made
        /// </summary>
        public DateTime TimeOfCreation { get; set; }
        /// <summary>
        /// Potential parent of the comment, the comment which this comment was an answer to
        /// </summary>
        public CommentDto ParentComment { get; set; }
    }
}
