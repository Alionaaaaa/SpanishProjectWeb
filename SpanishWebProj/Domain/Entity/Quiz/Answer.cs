using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Quiz
{
    public class Answer
    {
        public int Id { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }

        public string RightAnswer { get; set; }

        public string QuestionId { get; set; }

        public QuizQuestion QuizQuestion { get; set; }
    }
}