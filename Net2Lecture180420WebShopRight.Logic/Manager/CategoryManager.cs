using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net2Lecture180420WebShopRight.Logic
{
    public class CategoryManager
    {
        public static List<Categories> GetAll()
        {
            using (var db = new DBContext())
            {
                return db.Categories
                    .OrderBy(c => c.Name)
                    .ToList();
            }
        }

        public static Categories GetByName(string name)
        {
            using (var db = new DBContext())
            {
                return db.Categories.FirstOrDefault(c => c.Name == name);
            }
        }

        public static void Create(string name)
        {
            using (var db = new DBContext())
            {
                db.Categories.Add(new Categories()
                {
                    Name = name,
                });

                db.SaveChanges();
            }
        }
    }
}
