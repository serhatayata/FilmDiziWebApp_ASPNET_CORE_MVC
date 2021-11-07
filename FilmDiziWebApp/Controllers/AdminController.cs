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
        EfUserRepository ef = new EfUserRepository();
        public IActionResult Index()
        {
            var deger = ef.GetAll();
            return View(deger);
        }
    }
}
