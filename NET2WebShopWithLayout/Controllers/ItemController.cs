using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NET2WebShopWithLayout.Models;

namespace NET2WebShopWithLayout.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ItemModel model)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Buy(int id)
        {
            return View();
        }
    }
}