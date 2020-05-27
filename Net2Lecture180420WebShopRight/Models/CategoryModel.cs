using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Net2Lecture180420WebShopRight.Models
{
    public class CategoryModel
    {
        [Required]
        [Display(Name = "ID: ")]
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(150)]
        [Display(Name = "Name: ")]
        public string Name { get; set; }

    }
}
