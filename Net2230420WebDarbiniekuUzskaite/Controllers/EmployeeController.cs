using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Net2230420WebDarbiniekuUzskaite.Models;

namespace Net2230420WebDarbiniekuUzskaite.Controllers
{
    public class EmployeeController : Controller
    {
        public static List<EmployeeModel> Employees = new List<EmployeeModel>();
        public IActionResult Index()
        {
            var model = Employees
                .OrderBy(e => e.Surname)
                .ThenBy(e=> e.Department)
                .ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            EmployeeModel model = new EmployeeModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(EmployeeModel model)
        { 
            model.ID = Employees.Count + 1;
           
            if (ModelState.IsValid)
            {
                Employees.Add(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }
        public IActionResult ViewDepartments()
        {
            var model = Employees
                .OrderBy(e => e.Department)
                .Select(e => e.Department)
                .Distinct()
                .ToList();
            return View(model);
        }
    }
}