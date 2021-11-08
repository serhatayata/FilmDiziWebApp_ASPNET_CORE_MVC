using Data.Abstract;
using Data.Concrete.EfCore;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDiziWebApp.Controllers
{
    [Authorize(Roles ="A")]
    public class AdminController : Controller
    {
        private readonly IUserRepository usr;
        public AdminController(IUserRepository _usr)
        {
            usr = _usr;
        }
        public IActionResult Index()
        {
            var deger = usr.GetAll();
            return View(deger);
        }
    }
}
