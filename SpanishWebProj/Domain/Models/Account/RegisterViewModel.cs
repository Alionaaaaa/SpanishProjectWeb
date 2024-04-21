using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Introduceți numele")]
        [MaxLength(20, ErrorMessage = "Numele trebuie să aibă mai puțin de 20 de simboluri")]
        [MinLength(3, ErrorMessage = "Numele trebuie să aibă minimum 3 simboluri")]
        public string Name { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Introduceți parola")]
        [MinLength(6, ErrorMessage = "Parola trebuie să aibă mai mult de 6 simboluri!")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Introduceți parola încă odată")]
        [Compare("Password", ErrorMessage = "Parolele nu coincid")]
        public string PasswordConfirm { get; set; }
    }
}