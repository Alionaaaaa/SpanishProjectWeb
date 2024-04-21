

namespace Domain.Entity.Quiz
{
    public class Quiz
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public List<QuizQuestion> QuizQuestions { get; set; }

    }
}