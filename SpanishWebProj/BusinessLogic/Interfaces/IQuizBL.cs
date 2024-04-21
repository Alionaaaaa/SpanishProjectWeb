using Domain.Entity;
using Domain.Entity.Quiz;
using Domain.Models.Quiz;
using Domain.Response;

namespace BusinessLogic.Interfaces
{
    public interface IQuizBL
    {
        IBaseResponse<List<Quiz>> GetQuizes();
        Task<IBaseResponse<QuizViewModel>> GetQuizById(int id);
        Task<IBaseResponse<Quiz>> CreateQuiz(QuizViewModel Quiz);

        Task<IBaseResponse<bool>> DeleteQuiz(int id);

        Task<IBaseResponse<Quiz>> Edit(int id, QuizViewModel model);

        //Task<int> CalculateQuizScore(int quizId, Dictionary<int, string> answers);
    }
}

