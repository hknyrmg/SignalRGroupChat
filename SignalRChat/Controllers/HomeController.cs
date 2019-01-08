using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SignalRChat.viewModel;
using SignalRChat.Models;
using System.Diagnostics;

namespace SignalRChat.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("GetGroupName");
        }
        [HttpPost]
        public IActionResult Index(GroupUser s)
        {
            return View("Index", s);
        }

    }
}