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
    public class CommentController : Controller
    {
        EfUserRepository usr = new EfUserRepository();
        EfContentCommentRepository cm = new EfContentCommentRepository();

        
        public IActionResult Index()
        {
            var comments = cm.GetAll(x=>x.isDeleted==false);
            return View(comments);
        }
        [Authorize(Roles = "B")]
        [HttpPost]
        public IActionResult CreateComment(ContentComment cc, string Username)
        {
            var userId = usr.Get(x => x.Username == Username).UserID;
            cc.AddedTime = DateTime.Now;
            cc.UserID = userId;
            cm.Add(cc);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var com = cm.Get(x => x.CommentID == id);
            com.isDeleted = true;
            cm.Update(com);
            return RedirectToAction("Index");
        }

    }
}
