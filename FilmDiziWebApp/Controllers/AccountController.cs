using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDiziWebApp.Controllers
{
    public class AccountController : Controller
    {
        #nullable enable
        public IActionResult Login(string? model)
        {
            TempData["error1"] = "You have no authorization to enter this page.";
            return RedirectToAction("Index","Home");
        }
    }
}
