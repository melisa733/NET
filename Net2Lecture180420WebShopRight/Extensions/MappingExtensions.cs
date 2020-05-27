using Microsoft.AspNetCore.Identity;
using Net2Lecture180420WebShopRight.Logic;
using Net2Lecture180420WebShopRight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net2Lecture180420WebShopRight
{
    public static class MappingExtensions
    {
        public static CategoryModel ToCategoryModel(this Categories c) 
        {
            return new CategoryModel() {
                ID = c.Id,
                Name = c.Name
            };
        }

        public static ItemModel ToItemModel(this Items i)
        {
            if (i == null) {
                return null;
            }
            return new ItemModel()
            {
                ID = i.Id,
                Name = i.Name,
                Description = i.Description,
                Price = i.Price,
                Location = i.Location,
                Category = new CategoryModel()
                {
                    ID = i.CategoryId,
                }
            };
        }
    }
}
