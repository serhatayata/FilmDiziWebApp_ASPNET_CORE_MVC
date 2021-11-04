﻿using Data.Concrete.EfCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDiziWebApp.ViewComponents
{
    public class MovieOrSeriesViewComponent:ViewComponent
    {
        private FilmDiziDbContext db;
        public MovieOrSeriesViewComponent(FilmDiziDbContext _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}