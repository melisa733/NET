using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopWithLayOut.Logic.DB;
using WebShopWithLayOut.Models;

namespace WebShopWithLayOut
{
    public static class MappingExtensions
    {

        public static CategoryModel ToCategoryModel(this Categories c)
        {
            if (c == null)
            {
                return null;
            }
            return new CategoryModel()
            {
                Id = c.Id,
                Name = c.Name,
                ParentId = c.ParentId,
            };
        }

        public static ItemModel ToItemModel(this Items i)
        {
            if (i == null)
            {
                return null;
            }
            return new ItemModel()
            {
                Id = i.Id,
                Name = i.Name,
                CategoryId = i.CategoryId,
                Price = i.Price,
                Description = i.Description,
                Image = i.Image,
            };
        }

        public static UserModel ToUserModel(this Users user)
        {
            if (user == null)
            {
                return null;
            }
            return new UserModel()
            {
                Id = user.Id,
                EMail = user.EMail,
                Name = user.Name,
            };
        }

    }
}
