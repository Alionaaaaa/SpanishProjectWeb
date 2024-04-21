using Domain.Entity.Worksheet;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;


namespace Domain.Models.Worksheet
{
    public class WorksheetViewModel
    {

        [Display(Name = "Id")]
        public int Id { get; set; }
        
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Introduceți denumirea")]
        public string Name { get; set; }

        [Display(Name = "Path")]
        [Required(ErrorMessage = "Introduceți fișierul")]
        public string Path { get; set; }

        [Display(Name = "Level")]
        [Required(ErrorMessage = "Selectați nivelul")]
        public string Level { get; set; }

        [Display(Name = "NameCategory")]
        [Required(ErrorMessage = "Selectați categoria")]
        public string NameCategory { get; set; }

        public int WorksheetCategoryId { get; set; }

    }
}
