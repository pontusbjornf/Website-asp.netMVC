using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LogginSystem.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Fname { get; set; }
        [Required]

        public string Lname { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        //[DisplayName("Display Order")]
        //[Required]
        //[Range(1, int.MaxValue, ErrorMessage = "Display Order must be greater than 0")]

    }
}
