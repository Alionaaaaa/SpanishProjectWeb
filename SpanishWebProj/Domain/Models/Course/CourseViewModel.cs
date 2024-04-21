using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace Domain.Models.Course
{
    public class CourseViewModel
    {
        public long Id { get; set; }

        [Display(Name = "Denumirea cursului")]
        [Required(ErrorMessage = "Introduceți denumirea")]
        [MinLength(2, ErrorMessage = "Lungimea minimă trebuie să fie de minim 2 simboluri")]
        public string Name { get; set; }

        [Display(Name = "Descriere")]
        [MinLength(50, ErrorMessage = "Lungimea minimă trebuie să fie de minim 50 simboluri")]
        public string Description { get; set; }

        [Display(Name = "Tipul cursului")]
        [Required(ErrorMessage = "Introduceți tipul")]
        public string TypeCourse { get; set; }

        public IFormFile Avatar { get; set; }

        public byte[]? Image { get; set; }
    }
}
