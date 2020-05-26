using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Net2Lecture180420WebShopRight.Logic;
using Net2Lecture180420WebShopRight.Models;

namespace Net2Lecture180420WebShopRight.Controllers
{
    public class CategoryController : Controller
    {
        //1a
        public IActionResult Index()
        {
                 var categories = CategoryManager.GetAll()
                .Select(u => u.ToCategoryModel())
                .ToList();

                 return View(categories);
        }

        [HttpGet]
        public IActionResult Add()
        {
            CategoryModel model = new CategoryModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(CategoryModel model)
        {
            if (ModelState.IsValid)
            {
                CategoryManager.Create(model.Name);
     
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}