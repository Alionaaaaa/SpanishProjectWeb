
using System.ComponentModel.DataAnnotations;


namespace Domain.Models.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Introduceți numele")]
        [MaxLength(20, ErrorMessage = "Numele trebuie să aibă mai puțin de 20 de simboluri")]
        [MinLength(3, ErrorMessage = "Numele trebuie să aibă minimum 3 simboluri")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Introduceți parola")]
        [DataType(DataType.Password)]
        [Display(Name = "Parola")]
        public string Password { get; set; }
    }
}