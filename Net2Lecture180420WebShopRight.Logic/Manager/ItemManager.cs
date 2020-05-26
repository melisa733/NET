using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net2Lecture180420WebShopRight.Logic
{
    public class ItemManager
    {
        public static List<Items> GetAll()
        {
            using (var db = new DBContext())
            {
                return db.Items
                    .OrderBy(i => i.Price)
                    .ToList();
            }
        }

        public static Items Get(int id)
        {
            using (var db = new DBContext())
            {
                return db.Items.Find(id);
            }
        }

        public static void Create(string name, string description, decimal price, 
            string location, int categoryId)
        {
            using (var db = new DBContext())
            {
                db.Items.Add(new Items()
                {
                    Name = name,
                    Description = description,
                    Price = price,
                    Location = location,
                    CategoryId = categoryId,

                });
                db.SaveChanges();
            }
        }
    }
}
