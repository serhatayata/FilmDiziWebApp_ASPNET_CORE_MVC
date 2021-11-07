using Data.Concrete.EfCore;
using Entity.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FilmDiziWebApp.Controllers
{
    public class LoginController : Controller
    {
        private FilmDiziDbContext db;
        public LoginController(FilmDiziDbContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel model) 
        {
            var user = db.Users.FirstOrDefault(x=>x.Username == model.UserName && x.Password == model.Password);
            if (ModelState.IsValid)
            {
                if (user != null)
                {

                    ClaimsIdentity identity = null;
                    bool isAuthenticate = false;
                    if (user.Email == "srhtayata@gmail.com")
                    {
                        identity = new ClaimsIdentity(
                            new[]
                            {
                                new Claim(ClaimTypes.Name,model.UserName),
                                new Claim(ClaimTypes.Role,"A")
                            },CookieAuthenticationDefaults.AuthenticationScheme);
                        isAuthenticate = true;
                    }
                    else
                    {
                        identity = new ClaimsIdentity(
                            new[]
                            {
                               new Claim(ClaimTypes.Name,model.UserName),
                               new Claim(ClaimTypes.Role,"B")
                            },CookieAuthenticationDefaults.AuthenticationScheme);
                        isAuthenticate = true;
                    }
                    HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                    if (isAuthenticate==true && identity.Claims.Where(c => c.Type == ClaimTypes.Role)
                   .Select(c => c.Value).SingleOrDefault()=="A")
                    {
                        var principal = new ClaimsPrincipal(identity);
                        var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        return RedirectToAction("Index", "Admin");
                    }
                    else if (isAuthenticate)
                    {
                        var principal = new ClaimsPrincipal(identity);
                        var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError(nameof(model.UserName), "Your name or password is wrong!");
                    return View("Index", user);
                }
            }
            return View("Login");
        } 
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}

