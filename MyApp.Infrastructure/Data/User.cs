﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.Data
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="FullName is required")]
        public string FullName { get; set; }
        [Required(ErrorMessage ="UserName is required")]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [EmailAddress(ErrorMessage ="Email is not valid")]
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
