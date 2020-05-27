using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShopWithLayOut.Logic.DB;

namespace WebShopWithLayOut.Logic
{
    public class UserManager
    {
        public static Users GetByEmail(string email)
        {
            using (var db = new DBContext2())
            {
                return db.Users.FirstOrDefault(u => u.EMail == email);
            }
        }

        public static Users GetByEmailAndPassword(string email, string password) 
        {
            using (var db = new DBContext2()) 
            {
                return db.Users.FirstOrDefault(u => u.EMail == email && u.Password == password);
            };
        }

        public static void Create(string Email, string Password, string Name) 
        {
            using (var db = new DBContext2()) 
            {
                db.Users.Add(new Users(){ 
                    EMail = Email,
                    Password = Password,
                    Name = Name,
                });
                db.SaveChanges();
            };
        }
    }
}
