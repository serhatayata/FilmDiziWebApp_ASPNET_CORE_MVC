using Data.Concrete.EfCore;
using Entity.Concrete;
using FilmDiziWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDiziWebApp.Controllers
{
    public class HomeController : Controller
    {
        FilmDiziDbContext db;
        public HomeController(FilmDiziDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index(bool? id)
        {
            if (id!= null)
            {
                if (db.Contents.Count() > 1)
                {
                    if (id==true)
                    {
                        var deger = db.Contents.Where(x => x.IsItMovie == true).ToList().OrderByDescending(x => x.AddedTime);
                        return View("Index", deger);
                    }
                    else
                    {
                        var deger = db.Contents.Where(x => x.IsItMovie == false).ToList().OrderByDescending(x=>x.AddedTime);
                        return View("Index", deger);
                    }
                }
                else if (db.Contents.Count() == 1)
                {
                    var deger = db.Contents.Where(x => x.IsItMovie == false).FirstOrDefault();
                    return View("Index", deger);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            else
            {
                var deger = db.Contents.ToList().OrderByDescending(x => x.AddedTime);
                return View(deger);
            }
        }
    }
}
