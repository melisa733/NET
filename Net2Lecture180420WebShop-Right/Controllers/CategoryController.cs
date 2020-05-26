using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Net2Lecture180420WebShopRight.Models;

namespace Net2Lecture180420WebShopRight.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult View(int id)
        {
            return View();
        }
    }
}