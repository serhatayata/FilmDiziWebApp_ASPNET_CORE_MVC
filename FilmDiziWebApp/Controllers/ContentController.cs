using Data.Abstract;
using Data.Concrete.EfCore;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDiziWebApp.Controllers
{
    [Authorize(Roles = "A")]
    public class ContentController : Controller
    {

        private readonly IContentRepository ef;
        private readonly ICategoryRepository efCat;
        public ContentController(IContentRepository _ef,ICategoryRepository _efCat)
        {
            ef = _ef;
            efCat = _efCat;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var deger = ef.GetAll().Where(x => x.isDeleted == false);
            return View(deger);
        }
        [HttpGet]
        public IActionResult Create()
        {
            IEnumerable<SelectListItem> options;
            IEnumerable<SelectListItem> movieorViewOpt;
            options = efCat.GetAll().Select(a =>
              new SelectListItem
              {
                  Value = a.CategoryID.ToString(),
                  Text=a.CategoryName
              }).ToList();
            movieorViewOpt = new List<SelectListItem>()
            {
                new SelectListItem {Text = "Movie", Value=true.ToString()},
                new SelectListItem {Text="Series",Value=false.ToString()}
            };
            ViewBag.CategoryList = options;
            ViewBag.movieorViewList = movieorViewOpt;
            return View(new Content());
        }
        [HttpPost]
        public IActionResult Create(Content ct)
        {
            if (ModelState.IsValid)
            {
                ef.Add(ct);
                var d1 = ef.Get(x => x.ContentID == ct.ContentID);
                d1.AddedTime = DateTime.Now;
                ef.Update(d1);
                return RedirectToAction("Index");
            }
            else
            {
                return View(ct);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            IEnumerable<SelectListItem> options;
            IEnumerable<SelectListItem> movieorViewOpt;
            options = efCat.GetAll().Select(a =>
              new SelectListItem
              {
                  Value = a.CategoryID.ToString(),
                  Text = a.CategoryName
              }).ToList();
            movieorViewOpt = new List<SelectListItem>()
            {
                new SelectListItem {Text = "Movie", Value=true.ToString()},
                new SelectListItem {Text="Series",Value=false.ToString()}
            };
            ViewBag.CategoryList = options;
            ViewBag.movieorViewList = movieorViewOpt;
            var model = ef.Get(x => x.ContentID == id && x.isDeleted==false);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(Content ct)
        {
            ef.Update(ct);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = ef.Get(x => x.ContentID == id);
            model.isDeleted = true;
            ef.Update(model);
            return RedirectToAction("Index");
        }

    }
}
