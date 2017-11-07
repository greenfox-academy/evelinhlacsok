﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiWorkshop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiWorkshop.Models
{
    [Route("")]
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet]
        [Route("doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = input * 2 });
        }

        [HttpGet]
        [Route("greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            else
            return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
        }
    }
}