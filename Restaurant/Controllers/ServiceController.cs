﻿using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
