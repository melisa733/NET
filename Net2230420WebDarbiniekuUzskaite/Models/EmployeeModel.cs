using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Net2230420WebDarbiniekuUzskaite.Models
{
    public class EmployeeModel
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Name: ")]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Surname: ")]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Birth Year: ")]
        public DateTime BirthYear { get; set; }
        [Required]
        [Display(Name = "Position: ")]
        [DataType(DataType.Text)]
        [StringLength(200)]
        public string Position { get; set; }
        [Required]
        [Display(Name = "Department: ")]
        [DataType(DataType.Text)]
        [StringLength(200)]
        public string Department{ get; set; }
    }
}
