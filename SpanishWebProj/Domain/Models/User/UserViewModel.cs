using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.User
{
    public class UserViewModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Indicați rolul")]
        [Display(Name = "Rolul")]
        public string Role { get; set; }

        [Required(ErrorMessage = "Indicați login")]
        [Display(Name = "Login")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Indicați parola")]
        [Display(Name = "Parola")]
        public string Password { get; set; }
    }
}