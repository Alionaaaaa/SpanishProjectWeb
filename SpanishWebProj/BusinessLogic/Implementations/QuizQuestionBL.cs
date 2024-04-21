using BusinessLogic.Interfaces;
using DAL.Interfaces;
using DAL.Repositories;
using Domain.Entity.Quiz;
using Domain.Enum;
using Domain.Models.Quiz;
using Domain.Response;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Implementations
{
    public class QuizQuestionBL : IQuizQuestionBL
    {
        private readonly IBaseRepository<Quiz> _quizRepository; // Inject Quiz repository
        private readonly IBaseRepository<QuizQuestion> _quizQuestionRepository;
        public QuizQuestionBL( IBaseRepository<QuizQuestion> quizQuestionRepository, IBaseRepository<Quiz> quizRepository)
        {
            _quizQuestionRepository = quizQuestionRepository;
            _quizRepository = quizRepository;
        }

        public async Task<IBaseResponse<QuizQuestion>> Create(int quizId, QuizQuestionViewModel model)
        {
            try
            {

                var quiz = _quizRepository.GetAll().FirstOrDefault(x => x.Id == quizId);


                var quizQuestion = new QuizQuestion()
                {
                    QuestionText = model.QuestionText,
                    A = model.A,
                    B = model.B,
                    C = model.C,
                    D = model.D,
                    RightAnswer = model.RightAnswer,
                    QuizId = model.QuizId,
                };
                await _quizQuestionRepository.Create(quizQuestion);

                return new BaseResponse<QuizQuestion>()
                {
                    StatusCode = StatusCode.OK,
                    Data = quizQuestion
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<QuizQuestion>()
                {
                    Description = $"[Create] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        //public async Task<IBaseResponse<QuizQuestion>> Create( QuizQuestionViewModel question)
        //{
        //    try
        //    {
        //        // Retrieve the quiz entity from the database using the provided quizId
        //      //  var quiz = await _quizBL.GetQuizById(quizId);

        //        // Check if the quiz exists
        //        //if (quiz == null)
        //        //{
        //        //    return new BaseResponse<QuizQuestion>
        //        //    {
        //        //        StatusCode = StatusCode.QuizNotFound,
        //        //        Description = "Quiz not found"
        //        //    };
        //        //}

        //        // Map the QuizQuestionViewModel to a QuizQuestion entity
        //        var quizQuestion = new QuizQuestion
        //        {
        //            // Assuming properties are directly mapped
        //            QuestionText = question.QuestionText,
        //            A = question.A,
        //            B = question.B,
        //            C = question.C,
        //            D = question.D,
        //            RightAnswer = question.RightAnswer,
        //         //   QuizId = quizId // Associate the question with the retrieved quiz by setting the QuizId property
        //        };

        //        // Add the quiz question to the database using QuizQuestionRepository
        //        await _quizQuestionRepository.Create(quizQuestion);

        //        // Return a success response with the added question
        //        return new BaseResponse<QuizQuestion>
        //        {
        //            StatusCode = StatusCode.OK,
        //            Data = quizQuestion,
        //            Description = "Quiz question created successfully"
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle exceptions
        //        return new BaseResponse<QuizQuestion>
        //        {
        //            StatusCode = StatusCode.InternalServerError,
        //            Description = $"Failed to add question: {ex.Message}"
        //        };
        //    }
        //}





        public async Task<IBaseResponse<bool>> Delete(int id)
        {
            try
            {
                var quizQuestion = await _quizQuestionRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);
                if (quizQuestion == null)
                {
                    return new BaseResponse<bool>()
                    {
                        Description = "Not found",
                        StatusCode = StatusCode.UserNotFound,
                        Data = false
                    };
                }

                await _quizQuestionRepository.Delete(quizQuestion);

                return new BaseResponse<bool>()
                {
                    Data = true,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool>()
                {
                    Description = $"[DeleteQuiz] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }


        public Task<IBaseResponse<QuizQuestion>> Edit(int id, QuizQuestionViewModel model)
        {
            throw new NotImplementedException();
        }

        public IBaseResponse<List<QuizQuestion>> GetQuizQuestions()
        {
            throw new NotImplementedException();
        }
    }
}
