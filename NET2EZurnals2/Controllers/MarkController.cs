using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NET2EZurnals2.DataBase;
using NET2EZurnals2.Models;

namespace NET2EZurnals2.Controllers
{
    public class MarkController : Controller
    {

        //Iespēja apskatīt pilnu vērtējumu sarakstu (kārtotu pēc atzīmes, dilstoši).
       public IActionResult Index()
        {
           using (var db = new DBContext()) {    
                var model1 = db.Mark
                    .Join(
                        db.Students,
                        m => m.StudentId,
                        s => s.Id,
                        (m,s) => new MarkModel{
                            ID = m.Id,
                            MarkForStudent = m.Mark1,
                            Description = m.Description,
                            StudentInQ = new StudentModel() { 
                                ID = s.Id,
                                Name = s.Name,
                                Surname = s.Surname,
                                BirthDay = s.BirthDay,
                                Grade = s.Grade
                            },
                            SubjectInQ = new SubjectModel() { 
                                ID = m.SubjectId
                            }
                        }
                    ).Join(
                        db.Subjects,
                        m => m.SubjectInQ.ID,
                        sub => sub.Id,
                        (m, sub) => new MarkModel
                        {
                            ID = m.ID,
                            MarkForStudent = m.MarkForStudent,
                            Description = m.Description,
                            StudentInQ = new StudentModel()
                            {
                                ID = m.StudentInQ.ID,
                                Name = m.StudentInQ.Name,
                                Surname = m.StudentInQ.Surname,
                                BirthDay = m.StudentInQ.BirthDay,
                                Grade = m.StudentInQ.Grade
                            },
                            SubjectInQ = new SubjectModel()
                            {
                                ID = sub.Id,
                                Name = sub.Name,
                            }
                        }
                    )
                    .ToList();
                return View(model1);
            }
        }
        //Iespēja pievienot vērtējumu (skolēna uzvārds, vārds, mācību priekšmeta nosaukums, atzīme, apraksts).
        [HttpGet]
        public IActionResult Add()
        {
            MarkModel mark = new MarkModel();
            return View(mark);
        }

        [HttpPost]
        public IActionResult Add(MarkModel model)
        {
            if (ModelState.IsValid) 
            {
                using (var db = new DBContext()) 
                {
                    var student = db.Students
                        .FirstOrDefault(s => (s.Name == model.StudentName 
                        && s.Surname == model.StudentSurName));
                    var subject = db.Subjects
                        .FirstOrDefault(s => s.Name == model.SubjectName);
                    if (student != null && subject != null)
                    {
                        db.Mark.Add(new Mark
                        {
                            Mark1 = model.MarkForStudent,
                            Description = model.Description,
                            StudentId = student.Id,
                            SubjectId = subject.Id,
                        });
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else 
                    {
                        if (student == null && subject == null)
                        {
                            ModelState.AddModelError("student&subject", "There is no such student and subject!");
                        }
                        else if ( subject == null)
                        {
                            ModelState.AddModelError("subject", "There is no such subject!");
                        }
                        else
                        {
                            ModelState.AddModelError("student", "There is no such student!");
                        }
                    }
                }
            }
            return View();
        }

        //Iespēja apskatīt sarakstu ar skolēna atzīmēm (piemēram, no skolēnu saraksta ir iespēja doties uz skolēna atzīmju apskati).
        public IActionResult StudentMarks(int id)
        {
            using (var db = new DBContext())
            {
                var marks = db.Mark
                     .Join(
                         db.Students,
                         m => m.StudentId,
                         s => s.Id,
                         (m, s) => new MarkModel
                         {
                             ID = m.Id,
                             MarkForStudent = m.Mark1,
                             Description = m.Description,
                             StudentInQ = new StudentModel()
                             {
                                 ID = s.Id,
                                 Name = s.Name,
                                 Surname = s.Surname,
                                 BirthDay = s.BirthDay,
                                 Grade = s.Grade
                             },
                             SubjectInQ = new SubjectModel()
                             {
                                 ID = m.SubjectId
                             }
                         }
                     ).Join(
                         db.Subjects,
                         m => m.SubjectInQ.ID,
                         sub => sub.Id,
                         (m, sub) => new MarkModel
                         {
                             ID = m.ID,
                             MarkForStudent = m.MarkForStudent,
                             Description = m.Description,
                             StudentInQ = new StudentModel()
                             {
                                 ID = m.StudentInQ.ID,
                                 Name = m.StudentInQ.Name,
                                 Surname = m.StudentInQ.Surname,
                                 BirthDay = m.StudentInQ.BirthDay,
                                 Grade = m.StudentInQ.Grade
                             },
                             SubjectInQ = new SubjectModel()
                             {
                                 ID = sub.Id,
                                 Name = sub.Name,
                             }
                         }
                     )
                     .ToList();

                marks = marks
                    .Where(m => m.StudentInQ.ID == id)
                    .ToList();

                return View(marks);
            }
        }

        //Iespēja apskatīt sarakstu ar mācību priekšmeta atzīmēm(piemēram, no mācību priekšmetu saraksta ir iespēja doties uz priekšmeta atzīmju apskati).
        public IActionResult SubjectMarks(int id)
        {
            using (var db = new DBContext())
            {
                var marks = db.Mark
                     .Join(
                         db.Students,
                         m => m.StudentId,
                         s => s.Id,
                         (m, s) => new MarkModel
                         {
                             ID = m.Id,
                             MarkForStudent = m.Mark1,
                             Description = m.Description,
                             StudentInQ = new StudentModel()
                             {
                                 ID = s.Id,
                                 Name = s.Name,
                                 Surname = s.Surname,
                                 BirthDay = s.BirthDay,
                                 Grade = s.Grade
                             },
                             SubjectInQ = new SubjectModel()
                             {
                                 ID = m.SubjectId
                             }
                         }
                     ).Join(
                         db.Subjects,
                         m => m.SubjectInQ.ID,
                         sub => sub.Id,
                         (m, sub) => new MarkModel
                         {
                             ID = m.ID,
                             MarkForStudent = m.MarkForStudent,
                             Description = m.Description,
                             StudentInQ = new StudentModel()
                             {
                                 ID = m.StudentInQ.ID,
                                 Name = m.StudentInQ.Name,
                                 Surname = m.StudentInQ.Surname,
                                 BirthDay = m.StudentInQ.BirthDay,
                                 Grade = m.StudentInQ.Grade
                             },
                             SubjectInQ = new SubjectModel()
                             {
                                 ID = sub.Id,
                                 Name = sub.Name,
                             }
                         }
                     )
                     .ToList();

                marks = marks
                    .Where(m => m.SubjectInQ.ID == id)
                    .ToList();

                return View(marks);
            }
        }
    }
}