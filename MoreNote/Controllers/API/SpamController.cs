﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace MoreNote.Controllers.API
{
    [Route("api/Spam/[action]")]
    public class SpamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}