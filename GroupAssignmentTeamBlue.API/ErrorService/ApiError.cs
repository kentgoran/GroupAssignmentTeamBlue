using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.ErrorService
{
    /// <summary>
    /// parent class for handling errors
    /// </summary>
    public class ApiError
    {
        public ApiError() { }
        public ApiError(string code, string description) 
        {
            Code = code;
            Description = description;
        }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
