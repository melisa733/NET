using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET2WebShopWithLayout.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
    }
}
