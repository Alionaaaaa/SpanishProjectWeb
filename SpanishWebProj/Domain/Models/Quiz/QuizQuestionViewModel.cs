using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Quiz
{
    public class QuizQuestionViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Textul intrebarii")]
        [Required(ErrorMessage = "Introduceți textul intrebarii ")]
        [MinLength(3, ErrorMessage = "Lungimea minimă trebuie să fie de minim 3 simboluri")]
        public string QuestionText { get; set; }
        [Required(ErrorMessage = "Introduceți optiunea raspunsului ")]
        public string A { get; set; }
        [Required(ErrorMessage = "Introduceți optiunea raspunsului ")]
        public string B { get; set; }
        [Required(ErrorMessage = "Introduceți optiunea raspunsului ")]
        public string C { get; set; }
        [Required(ErrorMessage = "Introduceți optiunea raspunsului ")]
        public string D { get; set; }
        [Required(ErrorMessage = "Introduceți textul raspunsului corect")]
        public string RightAnswer { get; set; }
        public int QuizId { get; set; }




    }

}

