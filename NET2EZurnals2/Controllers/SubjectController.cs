using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NET2EZurnals2.DataBase;
using NET2EZurnals2.Models;

namespace NET2EZurnals2.Controllers
{
    public class SubjectController : Controller
    {
        
        //Iespēja apskatīt pilnu mācību priekšmetu sarakstu(kārtotu pēc nosaukuma, augoši).
        public IActionResult Index()
        {
            
            using (var db = new DBContext()) {
                var subjects = db.Subjects
                    .OrderBy(s => s.Name)
                    .Select(s => new SubjectModel()
                    {
                        ID = s.Id,
                        Name = s.Name
                    }).ToList();

                return View(subjects);
            }
        }

        //Iespēja pievienot jaunu mācību priekšmetu(nosaukums).
        public IActionResult Add()
        {
            SubjectModel model = new SubjectModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(SubjectModel model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new DBContext())
                {
                    var sub = db.Subjects
                        .FirstOrDefault(s => s.Name == model.Name);
                    if (sub == null)
                    {
                        db.Subjects.Add(new Subjects()
                        {
                            Name = model.Name
                        });
                        db.SaveChanges();

                        return RedirectToAction("Index");
                    }
                    else {
                        ModelState.AddModelError("cat", "There is already that kind of subject!");
                        return View(model);
                    }
                }
            }
            return View(model);
        }
        
    }
}