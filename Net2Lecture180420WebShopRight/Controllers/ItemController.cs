using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Net2Lecture180420WebShopRight.Models;
using Net2Lecture180420WebShopRight.Logic;

namespace Net2Lecture180420WebShopRight.Controllers
{
    public class ItemController : Controller
    {
        public ItemController() {
          
        }

        //kategorijas id
        public IActionResult Index(int? id)
        {
                var items = ItemManager.GetAll()
                    .Select(i => i.ToItemModel())
                    .ToList();

                if (id.HasValue) {
                    items = items
                        .Where(i => i.Category.ID == id)
                        .ToList();

                }

                return base.View(items);
        }

        public IActionResult View(int id)
        {
            var i = ItemManager.Get(id);
            var item = i.ToItemModel();

                return View(item);
        }

        [HttpGet]
        public IActionResult AddItem()
        {
            ItemModel model = new ItemModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddItem(ItemModel model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new DBContext())
                {
                    var category = CategoryManager.GetByName(model.CategoryName);
                    if (category != null)
                    {
                        ItemManager.Create(model.Name, model.Description, model.Price,
                            model.Location, category.Id);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("cat", "There is NoContent such category");
                    }
                }
            }
            return View(model);
        }
    }
}