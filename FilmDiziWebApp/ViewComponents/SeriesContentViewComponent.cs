using Data.Concrete.EfCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDiziWebApp.ViewComponents
{
    public class SeriesContentViewComponent:ViewComponent
    {
        private FilmDiziDbContext db;
        public SeriesContentViewComponent(FilmDiziDbContext _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            return View(db.Contents.Where(x=>x.IsItMovie==false).ToList().Take(5));
        }
    }
}
