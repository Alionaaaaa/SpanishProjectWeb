using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Enum
{
    public enum TypeQuestion
    {
        [Display(Name = "Multiple-Choice")] //alegere multipla a raspunsurilor
        MultipleChoice = 0,
        
        [Display(Name = "One-Choice")] //alegerea unui singur raspuns
        OneChoice = 1,

        [Display(Name = "True-False")] //adevarat sau fals
        TrueFalse = 2,

        [Display(Name = "Fill-in-Blank")] //completeaza spatiile libere
        FillInBlank = 3,
        
        [Display(Name = "Drag-and-Drop")] //trage raspunsurile in propozitie
        DragNDrop = 4,

        [Display(Name = "Matching")] //potrivire
        Matching = 5
    }
}