using LoginPage_NZ.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LoginPage_NZ.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
