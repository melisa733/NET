﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopWithLayOut.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail: ")]
        public string EMail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Repeat password: ")]
        public string PasswordRepeat { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Full name: ")]
        public string Name { get; set; }

    }
}
