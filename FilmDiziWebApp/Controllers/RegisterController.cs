using Data.Concrete.EfCore;
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
        public IActionResult Create(User user)
        {
            EfUserRepository efUser = new EfUserRepository();
            if (ModelState.IsValid)
            {
                user.Role = "B";
                efUser.Add(user);
            }
            else
            {
                return View("Index", user);
            }
            return RedirectToAction("Index","Login");
        }
    }
}
