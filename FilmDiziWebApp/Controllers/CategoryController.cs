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
    [Authorize(Roles = "A")]
    public class CategoryController : Controller
    {
        EfCategoryRepository ef = new EfCategoryRepository();
        [AllowAnonymous]
        public IActionResult Index()
        {
            var deger = ef.GetAll().Where(x=>x.isDeleted==false);
            return View(deger);
        }
       
        public IActionResult CategorySettings()
        {
            var ct = ef.GetAll().Where(x=>x.isDeleted==false);
            return View(ct);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Category());
        }
        [HttpPost]
        public IActionResult Create(Category ct)
        {
            if (ModelState.IsValid)
            {
                ef.Add(ct);
                return RedirectToAction("CategorySettings");
            }
            else
            {
                return View(ct);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = ef.Get(x => x.CategoryID == id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(Category ct)
        {
            ef.Update(ct);
            return RedirectToAction("CategorySettings");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = ef.Get(x => x.CategoryID == id);
            model.isDeleted = true;
            ef.Update(model);
            return RedirectToAction("CategorySettings");
        }
    }
}
