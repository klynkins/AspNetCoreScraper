﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreScraper.Controllers
{
    public class StocksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}