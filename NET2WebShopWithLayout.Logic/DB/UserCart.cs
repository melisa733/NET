using System;
using System.Collections.Generic;

namespace WebShopWithLayOut.Logic.DB
{
    public partial class UserCart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ItemsId { get; set; }

        public Items Items { get; set; }
        public Users User { get; set; }
    }
}
