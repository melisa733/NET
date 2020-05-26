using Microsoft.AspNetCore.Mvc.Internal;
using NET2EZurnals2.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NET2EZurnals2.Models
{
    public class StudentModel
    {

        public int ID { get; set; }
        [Required]
        [Display(Name = "Student name: ")]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Student surname: ")]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required]
        [Display(Name = "Birth Day: ")]
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
        [Required]
        [Display(Name = "Grade: ")]
        [DataType(DataType.Text)]
        [StringLength(20)]
        public string Grade { get; set; }
        public decimal AvrageGrade { get; set; }
    }
}
