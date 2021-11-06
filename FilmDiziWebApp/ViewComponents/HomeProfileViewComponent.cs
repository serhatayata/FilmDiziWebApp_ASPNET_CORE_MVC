using Data.Concrete.EfCore;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDiziWebApp.ViewComponents
{
    public class HomeProfileViewComponent:ViewComponent
    {
        private FilmDiziDbContext db;
        public HomeProfileViewComponent(FilmDiziDbContext _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            return View(new LoginModel());
        }
    }
}
