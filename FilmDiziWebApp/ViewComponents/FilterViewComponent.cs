using Data.Concrete.EfCore;
using Entity.Concrete;
using FilmDiziWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDiziWebApp.ViewComponents
{
    public class FilterViewComponent:ViewComponent
    {
        private FilmDiziDbContext db;
        public FilterViewComponent(FilmDiziDbContext _db)
        {
            db = _db;
        }

        public IViewComponentResult Invoke()
        {
            FilterViewModel filter = new FilterViewModel();
            var liste = new List<Category>();
            foreach (var item in db.Categories.ToList())
            {
                liste.Add(new Category() { CategoryID = item.CategoryID, CategoryName = item.CategoryName });
            }
            filter.CategoryList = liste;
            return View(filter);
        }
    }
}
