﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Port.Controllers
{
    public class CertificatesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
