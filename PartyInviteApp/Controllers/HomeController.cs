using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartyInviteApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInviteApp.Controllers
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

        public ViewResult Attending()
        {
            return View(PartyDb.Invites.Where(i => i.WillCome == true));
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(PartyInvitation partyInvitation)
        {
            if (ModelState.IsValid)
            {
                PartyDb.AddInvite(partyInvitation);
                return View("Thanks", partyInvitation);
            }
            else
            {
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
