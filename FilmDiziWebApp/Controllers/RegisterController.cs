using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDiziWebApp.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new User());
        }
        [HttpPost]
        public IActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                RedirectToAction("Home", "Index");
            }
            else
            {
                return View("Index", user);
            }
            return View();
        }
    }
}
