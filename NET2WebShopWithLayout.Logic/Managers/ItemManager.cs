using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShopWithLayOut.Logic.DB;

namespace WebShopWithLayOut.Logic
{
    public class ItemManager
    {
        public static List<Items> GetAll()
        {
            using(var db = new DBContext2()){
                return db.Items.OrderBy(i => i.Price)
                    .ToList();
            }
        }

        public static List<Items> GetByCategory(int id)
        {
            using(var db = new DBContext2()){
                return db.Items.Where(i => i.CategoryId == id)
                    .OrderBy(i => i.Price)
                    .ToList();
            }
        }
    }
}
