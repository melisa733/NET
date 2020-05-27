using WebShopWithLayOut.Logic.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebShopWithLayOut.Logic
{
    public class CategoryManager
    {
        public static List<Categories> GetAll()
        {
            using (var db = new DBContext2())
            {
                return db.Categories
                    .OrderBy(c => c.Name)
                    .ToList();
            }
        }
    }
}
