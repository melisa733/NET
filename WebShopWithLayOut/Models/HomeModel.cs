using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopWithLayOut.Models
{
    public class HomeModel
    {
        public List<ItemModel> Items { get; set; }
        public List<CategoryModel> Categories { get; set; }
    }
}
