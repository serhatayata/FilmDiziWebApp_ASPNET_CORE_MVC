using Data.Abstract;
using Data.Concrete.EfCore;
using Entity.Concrete;
using FilmDiziWebApp.Models;
using FilmDiziWebApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FilmDiziWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryRepository ct;
        private readonly IAboutUsRepository abt;
        private readonly IContentRepository cont;
        private readonly IUserRepository usr;
        private readonly IContentCommentRepository cm;
        FilmDiziDbContext db;
        public HomeController(FilmDiziDbContext _db, IUserRepository _usr, IContentCommentRepository _cm,IContentRepository _cont, IAboutUsRepository _abt, ICategoryRepository _ct)
        {
            db = _db;
            usr = _usr;
            cm = _cm;
            cont = _cont;
            abt = _abt;
            ct = _ct;
        }
        public IActionResult Index(bool? id)
        {
            if (id!= null)
            {
                if (db.Contents.Count() > 1)
                {
                    if (id==true)
                    {
                        var deger = cont.GetAll().Where(x => x.IsItMovie == true && x.isDeleted==false).ToList().OrderByDescending(x => x.AddedTime);
                        return View("Index", deger);
                    }
                    else
                    {
                        var deger = cont.GetAll().Where(x => x.IsItMovie == false && x.isDeleted == false).ToList().OrderByDescending(x=>x.AddedTime);
                        return View("Index", deger);
                    }
                }
                else if (db.Contents.Count() == 1)
                {
                    var deger = cont.GetAll().Where(x => x.IsItMovie == true && x.isDeleted == false).FirstOrDefault();
                    return View("Index", deger);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            else
            {
                var deger = cont.GetAll().Where(x=>x.isDeleted==false).OrderByDescending(x => x.AddedTime);
                return View(deger);
            }
        }
        //Search
        #nullable enable
        [HttpPost]
        public IActionResult SearchContent(string? Search)
        {
            if (Search != null)
            {
                var contents = cont.GetAll(x => x.Name.ToLower().Contains(Search.ToLower()) && x.isDeleted == false);
                return View("Index",contents);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public IActionResult Filter(string type,FilterViewModel f,string year)
        {
            IEnumerable<Content> deger = cont.GetAll().Where(x=>x.isDeleted==false);
            if (type=="true")
            {
                deger = deger.Where(x => x.IsItMovie == true).ToList();
            }
            else if(type=="false")
            {
                deger = deger.Where(x => x.IsItMovie == false).ToList();
            }
            else if(type == "all")
            {
                deger = db.Contents.ToList();
            }
            if (deger.Any(x => x.CategoryID == f.CategoryID))
            {
                deger = deger.Where(x => x.CategoryID == f.CategoryID).ToList();
            }
            switch (year)
            {
                
                case "0": deger = deger.Where(x => x.Year <= (new DateTime(2001,1,1))).ToList();  break;
                case "1": deger = deger.Where(x => x.Year < (new DateTime(2006, 1, 1)) && x.Year > (new DateTime(2001,1,1))).ToList(); break;
                case "2": deger = deger.Where(x => x.Year <= (new DateTime(2012, 1, 1)) && x.Year > (new DateTime(2006, 1, 1))).ToList(); break;
                case "3": deger = deger.Where(x => x.Year <= (new DateTime(2018, 1, 1)) && x.Year > (new DateTime(2012, 1, 1))).ToList(); break;
                case "4": deger = deger.Where(x => x.Year < DateTime.Now && x.Year > (new DateTime(2018, 1, 1))).ToList(); break;
                default: deger = deger.ToList();
                    break;
            }
            return View("Index",deger);
        }

        public IActionResult Categories()
        {
            return View(ct.GetAll().Where(x=>x.isDeleted==false));
        }

        public IActionResult Details(int id)
        {
            if (User.Identity != null && User.Identity.IsAuthenticated ==true)
            {
                var identity = (ClaimsIdentity)User.Identity;
                string username = identity.Claims.ToList()[0].Value;
                ViewBag.username = username;
            }
            ViewData["cm"] = cm.GetAll(x => x.ContentID == id);
            var deger = cont.Get(x=>x.ContentID==id && x.isDeleted==false);
            return View(deger);
        }
        public IActionResult AboutUs()
        {
            var deger = abt.GetAll().FirstOrDefault();
            return View(deger);
        }
        

    }
}
