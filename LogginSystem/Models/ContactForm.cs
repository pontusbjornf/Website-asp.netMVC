using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LogginSystem.Models
{
    public class ContactForm
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
        public string Number { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
