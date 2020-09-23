using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.ErrorService
{
    /// <summary>
    /// Error class, used to throw errors in the correct syntax from the API
    /// </summary>
    public class ApiErrorResponseBody
    {
        /// <summary>
        /// Constructor, succeeded defaults to false
        /// </summary>
        /// <param name="succeded">indicates if the action was a success or not, defaults to false</param>
        public ApiErrorResponseBody(bool succeded = false)
        {
            Succeded = succeded;
            Errors = new Dictionary<string, string[]>();
        }
        /// <summary>
        /// Indicates whether the action was successfull or not
        /// </summary>
        public bool Succeded { get; set; }
        /// <summary>
        /// A dictionary of errors
        /// </summary>
        public Dictionary<string, string[]> Errors { get; }
        /// <summary>
        /// Used to add a new error to the responseBody
        /// </summary>
        /// <param name="errorParent">Parent name</param>
        /// <param name="errors">an array of strings, containing all the errors of it's parent</param>
        public void AddError(string errorParent, string[] errors)
        {
            Errors.Add(errorParent, errors);
        }
    }
}
