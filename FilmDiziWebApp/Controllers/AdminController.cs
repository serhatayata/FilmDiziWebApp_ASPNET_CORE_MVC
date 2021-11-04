﻿using Data.Concrete.EfCore;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDiziWebApp.Controllers
{
    public class AdminController : Controller
    {
        private FilmDiziDbContext db;
        public AdminController(FilmDiziDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var deger = db.Users.ToList();
            return View(deger);
        }
    }
}
