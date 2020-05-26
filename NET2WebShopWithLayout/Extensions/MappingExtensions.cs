using NET2WebShopWithLayout.Logic.DB;
using NET2WebShopWithLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET2WebShopWithLayout.Extensions
{
    public static class MappingExtensions
    {

        public static CategoryModel ToCategoryModel(this Categories c) 
        {
            return new CategoryModel()
            {
                Id = c.Id,
                Name = c.Name,
                ParentId = c.ParentId,
            };
        }

    }
}
