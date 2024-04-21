using Domain.Enum;

namespace Domain.Entity.Quiz
{
    public class QuizQuestion
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }

        public string RightAnswer { get; set; }

        public int QuizId { get; set; }

        public virtual Quiz Quiz { get; set; }
        

    }
}