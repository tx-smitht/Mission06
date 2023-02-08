﻿using DateMe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DateMe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FillOutApplication()
        {
            return View("DatingApplication");
        }

        [HttpPost]
        public IActionResult FillOutApplication(ApplicationResponse ar)
        {
            // This checks if all the form has everything that it needs to 
            if (ModelState.IsValid)
            {
                return View("Confirmation", ar); // This is like context in Django
            }
            else
            {
                // If it is missing things, it will return the application page with
                // the error messages
                return View("DatingApplication");
            }
            
        }

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
