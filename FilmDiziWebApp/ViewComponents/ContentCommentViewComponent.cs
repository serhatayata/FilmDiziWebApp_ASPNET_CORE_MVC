using Data.Concrete.EfCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDiziWebApp.ViewComponents
{
    public class ContentCommentViewComponent:ViewComponent
    {
        EfContentCommentRepository ef = new EfContentCommentRepository();
        EfUserRepository user = new EfUserRepository();
        public IViewComponentResult Invoke(int? contentID)
        {
            var comments = ef.GetAll(x => x.ContentID == contentID);
            return View(comments);
        }
    }
}
