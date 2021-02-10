using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Load Index page and pass in the top five restaurant data from Restaurants.cs
        public IActionResult Index()
        {
            List<string> restList = new List<string>();

            foreach (Restaurants r in Restaurants.GetRests())
            {
                restList.Add($"#{r.RestRank} {r.RestName} {r.FavDish} at {r.Address}, {r.PhoneNum}, {r.WebLink}");
            }

            return View(restList);
        }

        // Add a route AddRest(aurant) view fresh form
        [HttpGet]
        public IActionResult AddRest()
        {
            return View();
        }
        // Add a route to the AddRest(aurant) Confirmation View after submit button
        [HttpPost]
        public IActionResult AddRest(RestResponse restResponse)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddApplication(restResponse);
                return View("Confirmation", restResponse);
            }
            else
            {
                return View();
            }
        }

        // Backup way to navigate to confirmation page
        public IActionResult Confirmation()
        {
            return View();
        }

        // Backup way to navigate to see suggestions list page

        public IActionResult SeeSug()
        {
            return View(TempStorage.Applications);
        }
        // Backup way to navigate to privacy page
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
