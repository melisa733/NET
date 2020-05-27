using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShopWithLayOut.Logic;
using WebShopWithLayOut.Models;

namespace WebShopWithLayOut.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult SingUp()
        {
            var model = new UserModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult SingUp(UserModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Password != model.PasswordRepeat)
                {
                    ModelState.AddModelError("pass", "Passwords doesn't match!");
                }
                else
                {
                    UserModel user = UserManager.GetByEmail(model.EMail).ToUserModel();
                    if (user != null)
                    {
                        ModelState.AddModelError("mail", "User with this e-mail already exists!");
                    }
                    else
                    {
                        UserManager.Create(model.EMail, model.Password, model.Name);
                        return RedirectToAction("SingIn");
                    }
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult SingIn()
        {
            var model = new LoginModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult SingIn(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                UserModel user = UserManager.GetByEmailAndPassword(model.EMail, model.Password).ToUserModel();

                if (user == null)
                {
                    ModelState.AddModelError("user", "Invalid user!");
                }
                else
                {
                    HttpContext.Session.SetUserName(user.Name);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        public IActionResult SingOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
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