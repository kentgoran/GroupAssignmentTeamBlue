using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.ValidationAttributes
{
    /// <summary>
    /// Validates a list of strings, so that all urls are valid
    /// </summary>
    public class ListOfUrlsValidateAll : ValidationAttribute
    {
        /// <summary>
        /// Validates a list of strings, so that they are all valid urls using UrlAttribute.IsValid()
        /// </summary>
        /// <param name="value"></param>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                List<string> urls = value as List<string>;
                //Check for null, so to not validate an empty input (would throw ArgumentNullException)
                if(urls != null)
                {
                    UrlAttribute urlCheck = new UrlAttribute();
                    foreach (string url in urls)
                    {
                        if (!urlCheck.IsValid(url))
                        {
                            return new ValidationResult(ErrorMessage,
                                new[] { nameof(List<string>) });
                        }
                    }
                }

                return ValidationResult.Success;
            }
            catch (Exception ex)
            {
                return new ValidationResult(ex.Message,
                    new[] { nameof(List<string>) });
            }
        }
    }
}
