using Data.Concrete.EfCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDiziWebApp.ViewComponents
{
    public class MovieContentViewComponent:ViewComponent
    {
        private FilmDiziDbContext db;
        public MovieContentViewComponent(FilmDiziDbContext _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            return View(db.Contents.Where(x=>x.IsItMovie==true).ToList().Take(5));
        }
    }
}
