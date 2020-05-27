using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebShopWithLayOut.Models;
using WebShopWithLayOut.Logic;

namespace WebShopWithLayOut.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new HomeModel();
            model.Items = new List<ItemModel>();
            model.Categories = CategoryManager.GetAll()
                .Select(c => c.ToCategoryModel())
                .ToList();

            return View(model);
        }
    }
}