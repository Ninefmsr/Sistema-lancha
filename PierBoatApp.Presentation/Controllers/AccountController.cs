using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using PierBoatApp.Presentation.Models.Account;
using System.Security.Claims;

namespace PierBoatApp.Presentation.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(AccountLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if ("teste@gmail.com".Equals(model.Email) && "Admin2024*".Equals(model.Senha))
                {
                    var claimsIdentity = new ClaimsIdentity(new[] {
                        new Claim(ClaimTypes.Email, model.Senha)
                    }, CookieAuthenticationDefaults.AuthenticationScheme);

                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["MensagemErro"] = "Acesso negado. Usuário inválido.";
                }
            }
            return View();
        }

        /// Método para fazer o logout do usuário no sistema
        /// /Account/Logout
        /// </summary>
        public IActionResult Logout()
        {
            //apagar o cookir de autenticação gravado no navegador
            HttpContext.SignOutAsync
            (CookieAuthenticationDefaults.AuthenticationScheme);
            //redirecionar o usuário de volta para a página de login
            return RedirectToAction("Login");
        }
    }
}
