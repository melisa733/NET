using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net2Lecture180220WebShop.Models
{
    public class ItemModel
    {
       
        public int ID { get; set; }
        public int categoryId { get; set; }
        public string itemName { get; set; }
        public double price { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string category { get; set; }
    }
}
