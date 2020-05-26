using System;
using System.Collections.Generic;

namespace NET2EZurnals2.DataBase
{
    public partial class Mark
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public decimal Mark1 { get; set; }
        public string Description { get; set; }
    }
}
