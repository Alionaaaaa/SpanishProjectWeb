using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Account
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Introduceți numele")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Introduceți parola")]
        [DataType(DataType.Password)]
        [Display(Name = "Parola")]
        [MinLength(6, ErrorMessage = "Parola trebuie să aibă mai mult de 6 simboluri!")]
        public string NewPassword { get; set; }
    }
}