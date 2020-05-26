using NET2WebShopWithLayout.Logic.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NET2WebShopWithLayout.Logic
{
    public static class CategoryManager
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
