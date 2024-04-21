using Domain.Entity.Quiz;
using Domain.Models.Quiz;
using Domain.Response;

namespace BusinessLogic.Interfaces
{
    public interface IQuizQuestionBL
    {
        IBaseResponse<List<QuizQuestion>> GetQuizQuestions();
        Task<IBaseResponse<QuizQuestion>> Create(int quizId, QuizQuestionViewModel model);

        Task<IBaseResponse<bool>> Delete(int id);

        Task<IBaseResponse<QuizQuestion>> Edit(int id, QuizQuestionViewModel model);
        



    }
}

