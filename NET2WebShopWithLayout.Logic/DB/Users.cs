using System;
using System.Collections.Generic;

namespace WebShopWithLayOut.Logic.DB
{
    public partial class Users
    {
        public Users()
        {
            UserCart = new HashSet<UserCart>();
        }

        public int Id { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public ICollection<UserCart> UserCart { get; set; }
    }
}
