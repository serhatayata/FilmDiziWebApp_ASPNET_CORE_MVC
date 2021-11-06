using Data.Concrete.EfCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDiziWebApp.Controllers
{
    public class CategoryController : Controller
    {
        private FilmDiziDbContext db;
        public CategoryController(FilmDiziDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var deger = db.Categories.ToList();
            return View(deger);
        }
        //[Authorize(Roles ="B")]
        //public IActionResult UserIndex()
        //{
        //    var deger = db.Categories.ToList();
        //    return View(deger);
        //}
    }
}
