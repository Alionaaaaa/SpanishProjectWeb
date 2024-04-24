using Domain.Entity.Quiz;
using System.ComponentModel.DataAnnotations;


namespace Domain.Models.Quiz
{
    public class QuizViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Denumirea quizului")]
        [Required(ErrorMessage = "Introduceți denumirea quizului ")]
        [MinLength(3, ErrorMessage = "Lungimea minimă trebuie să fie de minim 3 simboluri")]
        public string Name { get; set; }
        public string SelectedOption { get; set; } //user selected radio buttons
        public int? TotalScore { get; set; }

        public List<QuizQuestion>? Questions { get; set; }

    
    
    
    }
}
