using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NET2EZurnals2.Models
{
    public class MarkModel
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Mark: ")]
        public decimal MarkForStudent { get; set; }
        [Display(Name = "Description: ")]
        [DataType(DataType.Text)]
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Student Name: ")]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string StudentName { get; set; }
        [Required]
        [Display(Name = "Student Surname: ")]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string StudentSurName { get; set; }
        [Required]
        [Display(Name = "Subject Name: ")]
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string SubjectName { get; set; }
        public StudentModel StudentInQ { get; set; }
        public SubjectModel SubjectInQ { get; set; }
    }
}
