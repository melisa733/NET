using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NET2EZurnals2.DataBase;
using NET2EZurnals2.Models;

namespace NET2EZurnals2.Controllers
{
    public class StudentController : Controller
    {

        //Iespēja apskatīt pilnu skolēnu sarakstu (kārtotu pēc uzvārda un vārda, augoši).
        public IActionResult Index()
        {
            using (var db = new DBContext())
            {
                var students = db.Students
                    .OrderBy(s => s.Surname)
                    .ThenBy(s => s.Name)
                    .Select(s => new StudentModel
                    {
                        ID = s.Id,
                        Name = s.Name,
                        Surname = s.Surname,
                        BirthDay = s.BirthDay,
                        Grade = s.Grade
                    }).ToList();

                return View(students);
            }
        }

        //Iespēja pievienot jaunu skolēnu (vārds, uzvārds, dzimšanas gads, klase).
        [HttpGet]
        public IActionResult Add()
        {
            StudentModel student = new StudentModel();
            return View(student);
        }

        [HttpPost]
        public IActionResult Add(StudentModel student)
        {
            if (ModelState.IsValid)
            {
                using (var db = new DBContext())
                {
                    var stu = db.Students
                           .FirstOrDefault(s => (s.Name == student.Name && s.Surname == student.Surname));
                    if (stu == null)
                    {
                        db.Students.Add(new Students()
                        {
                            Name = student.Name,
                            Surname = student.Surname,
                            BirthDay = student.BirthDay,
                            Grade = student.Grade
                        });
                        db.SaveChanges();

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("student", "There is already that kind of student!");
                        return View(student);
                    }
                }
            }
            return View(student);
        }

        //Iespēja apskatīt pilnu skolēnu sarakstu ar katra skolēna vidējo atzīmi (uzvārds, vārds, klase, vidējā atzīme visos mācību priekšmetos).
        public IActionResult StudentsWithAvrageMark()
        {
            using (var db = new DBContext())
            {
                var students = db.Students
                    .Select(s => new StudentModel() { 
                        ID = s.Id,
                        Name = s.Name,
                        Surname = s.Surname,
                        BirthDay = s.BirthDay,
                        Grade = s.Grade
                    })
                    .ToList();

                var marks = db.Mark
                        .Select(m => new MarkModel() {
                            MarkForStudent = m.Mark1,
                            StudentInQ = new StudentModel() { 
                                ID = m.StudentId
                            }, 
                            SubjectInQ = new SubjectModel() { 
                                ID = m.SubjectId
                            },
                            Description = m.Description
                        })
                        .ToList();

                decimal Count;
                decimal Sum;
                foreach (var student in students) 
                {
                    Count = 0;
                    Sum = 0;
                    foreach (var mark in marks)
                    {
                        if (mark.StudentInQ.ID == student.ID) 
                        {
                            Count++;
                            Sum = Sum + mark.MarkForStudent;
                        }
                    }
                    if (Count == 0)
                    {
                        student.AvrageGrade = 0;
                    }
                    else 
                    {
                        student.AvrageGrade = Sum / Count;
                    }
                }
                return View(students);
            }
        }
    }
 }