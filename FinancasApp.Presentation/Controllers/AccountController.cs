using Microsoft.AspNetCore.Mvc;

namespace FinancasApp.Presentation.Controllers

    
{
    public class AccountController : Controller
    {
        /// <summary>
        /// Método para abrir página  Account/Login
        /// </summary>
        /// <returns></returns>
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// Método para abrir página  Account/Register
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// Método para abrir página  Account/ForgotPassword
        /// </summary>
        /// <returns></returns>
        public IActionResult ForgotPassword()
        {
            return View();
        }


    }
}
