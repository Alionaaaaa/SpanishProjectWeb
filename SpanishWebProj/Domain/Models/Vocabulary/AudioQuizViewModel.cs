using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Vocabulary
{
    public class AudioQuizViewModel
    {
        public string LessonSubject { get; set; } // Subiectul lecției audio
        public string LessonImagePath { get; set; } // Calea către imaginea lecției audio
        public List<AudioQuizQuestionViewModel> Questions { get; set; } // Lista de întrebări pentru quiz

        public AudioQuizViewModel()
        {
            Questions = new List<AudioQuizQuestionViewModel>();
        }
    }

    public class AudioQuizQuestionViewModel
    {
        public string QuestionText { get; set; } // Textul întrebării în spaniolă
        public string CorrectAnswer { get; set; } // Răspunsul corect în română
        public string ImagePath { get; set; } // Calea către imaginea asociată întrebării
        public string? SoundSpanishPath { get; set; }
        public string? SoundRomanianPath { get; set; }

        public List<string> Options { get; set; } // Lista de opțiuni de răspuns în română

        public AudioQuizQuestionViewModel()
        {
            Options = new List<string>();
        }
    }
}