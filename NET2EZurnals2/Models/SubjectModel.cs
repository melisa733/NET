using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NET2EZurnals2.Models
{
    public class SubjectModel
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Subject: ")]
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
