﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net2Lecture180420WebShopRight.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string Location { get; set; }
        public CategotyModel category{ get; set; }
    }
}
