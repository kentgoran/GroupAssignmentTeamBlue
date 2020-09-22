using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.ErrorService
{
    public class ApiErrorResponseBody
    {
        public ApiErrorResponseBody() { }
        public ApiErrorResponseBody(bool succeded, ICollection<ApiError> errors)
        {
            Succeded = succeded;
            Errors = errors;
        }
        public bool Succeded { get; set; }
        public ICollection<ApiError> Errors { get; set; }
    }
}
