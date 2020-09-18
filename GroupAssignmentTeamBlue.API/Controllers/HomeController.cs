using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GroupAssignmentTeamBlue.API.Models;

namespace GroupAssignmentTeamBlue.API.Controllers
{
    /// <summary>
    /// Default page controller
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger"></param>
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Index page
        /// </summary>
        /// <returns>A view</returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Privacy page
        /// </summary>
        /// <returns>A view</returns>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// Error page
        /// </summary>
        /// <returns>An error-view</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
