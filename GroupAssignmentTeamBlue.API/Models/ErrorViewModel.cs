using System;

namespace GroupAssignmentTeamBlue.API.Models
{
    /// <summary>
    /// ViewModel for errors
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>
        /// Id of the request
        /// </summary>
        public string RequestId { get; set; }
        /// <summary>
        /// Tells if the requestId is to be shown or not
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
