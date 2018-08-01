using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Autenticacion18.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(Usuario usuario)
        {
            var claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.Name, usuario.Username));
            claims.Add(new Claim(ClaimTypes.Email, usuario.Username));

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);

            return Redirect("/");

        }


        [HttpPost]

        public IActionResult Login()
        {
            var estaAutenticado = HttpContext.User.Identity.IsAuthenticated;

            if (estaAutenticado)
            {
                return Redirect("/");
            }

            return View();
        }

 


        [HttpGet]
        [HttpPost]
        public async Task<IActionResult> Logout(Usuario usuario)
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return Redirect("/Account/Login");
        }

    }
}
