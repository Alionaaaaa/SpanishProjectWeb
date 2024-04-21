using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Profile
{
    public class ProfileViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Indicați vârsta")]
        [Range(0, 150, ErrorMessage = "Vârsta trebuie să fie între 0 și 120")]
        public string? Image { get; set; }
        public TypeCourse Level { get; set; }
        public int Age { get; set; }

        [Required(ErrorMessage = "Indicați numele")]
        public string UserName { get; set; }

    }
}