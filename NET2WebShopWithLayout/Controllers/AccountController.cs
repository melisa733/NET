using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NET2WebShopWithLayout.Models;

namespace NET2WebShopWithLayout.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult SingUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SingUp(UserModel model)
        {
            return View();
        }

        [HttpGet]
        public IActionResult SingIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SingIn(LoginModel model)
        {
            return View();
        }

        public IActionResult MyCart()
        {
            return View();
        }

        public IActionResult Confirm()
        {
            return View();
        }
    }
}