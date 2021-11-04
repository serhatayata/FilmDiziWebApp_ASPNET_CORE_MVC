using Data.Concrete.EfCore;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDiziWebApp.Controllers
{
    public class AdminController : Controller
    {
        private FilmDiziDbContext context;
        public AdminController(FilmDiziDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
