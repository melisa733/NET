using System;
using System.Collections.Generic;

namespace NET2EZurnals2.DataBase
{
    public partial class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDay { get; set; }
        public string Grade { get; set; }
    }
}
