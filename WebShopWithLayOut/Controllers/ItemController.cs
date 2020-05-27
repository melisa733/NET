using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShopWithLayOut.Logic;
using WebShopWithLayOut.Models;

namespace WebShopWithLayOut.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index(int id)
        {
            HomeModel model = new HomeModel();
            model.Categories = CategoryManager.GetAll()
                .Select(c => c.ToCategoryModel())
                .ToList();

            model.Items = ItemManager.GetByCategory(id)
                .Select(c => c.ToItemModel())
                .ToList();
            return View(model);
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