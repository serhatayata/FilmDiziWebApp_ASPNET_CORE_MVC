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
        EfContentRepository ef = new EfContentRepository();
        public IViewComponentResult Invoke()
        {
            return View(ef.GetAll().Where(x => x.IsItMovie == false && x.isDeleted == false).Take(5));
        }
    }
}
