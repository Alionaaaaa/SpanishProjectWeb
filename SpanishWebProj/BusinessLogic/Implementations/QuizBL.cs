using BusinessLogic.Interfaces;
using DAL.Interfaces;
using DAL.Repositories;
using Domain.Entity;
using Domain.Entity.Quiz;
using Domain.Enum;
using Domain.Models.Quiz;
using Domain.Response;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Implementations
{
    public class QuizBL : IQuizBL
    {
        private readonly IBaseRepository<Quiz> _quizRepository;

        public QuizBL(IBaseRepository<Quiz> quizRepository)
        {
            _quizRepository = quizRepository;
        }


        public IBaseResponse<List<Quiz>> GetQuizes()
        {
            try
            {
                var quiz = _quizRepository.GetAll().ToList();
                if (!quiz.Any())
                {
                    return new BaseResponse<List<Quiz>>()
                    {
                        Description = "Nu sunt găsite quiz-uri",
                        StatusCode = StatusCode.OK
                    };
                }

                return new BaseResponse<List<Quiz>>()
                {
                    Data = quiz,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<List<Quiz>>()
                {
                    Description = $"[GetQuiz] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<QuizViewModel>> GetQuizById(int id)
        {
            try
            {
                var quiz = await _quizRepository.GetAll()
                    .Include(q => q.QuizQuestions) // Include related QuizQuestions
                    .FirstOrDefaultAsync(x => x.Id == id);

                if (quiz == null)
                {
                    return new BaseResponse<QuizViewModel>()
                    {
                        Description = "Quiz not found",
                        StatusCode = StatusCode.QuizNotFound
                    };
                }

                var quizViewModel = new QuizViewModel()
                {
                    Id = quiz.Id,
                    Name = quiz.Name,
                    Questions = quiz.QuizQuestions.Select(q => new QuizQuestion
                    {
                        Id = q.Id,
                        QuestionText = q.QuestionText,
                        A = q.A,
                        B = q.B,
                        C = q.C,
                        D = q.D,
                        RightAnswer = q.RightAnswer
                    }).ToList()
                };

                return new BaseResponse<QuizViewModel>()
                {
                    Data = quizViewModel,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<QuizViewModel>()
                {
                    Description = $"[GetQuizById] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<Quiz>> CreateQuiz(QuizViewModel model)
        {
            try
            {
                var quiz = new Quiz()
                {
                    Name = model.Name
                };
                await _quizRepository.Create(quiz);

                return new BaseResponse<Quiz>()
                {
                    StatusCode = StatusCode.OK,
                    Data = quiz
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Quiz>()
                {
                    Description = $"[Create] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<bool>> DeleteQuiz(int id)
        {
            try
            {
                var quiz = await _quizRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);
                if (quiz == null)
                {
                    return new BaseResponse<bool>()
                    {
                        Description = "Not found",
                        Data = false
                    };
                }

                await _quizRepository.Delete(quiz);

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




        public async Task<IBaseResponse<Quiz>> Edit(int id, QuizViewModel model)
        {
            try
            {
                var quiz = await _quizRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);
                if (quiz == null)
                {
                    return new BaseResponse<Quiz>()
                    {
                        Description = "Quiz not found",
                        StatusCode = StatusCode.QuizNotFound
                    };
                }

                quiz.Name = model.Name;

                await _quizRepository.Update(quiz);


                return new BaseResponse<Quiz>()
                {
                    Data = quiz,
                    StatusCode = StatusCode.OK,
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Quiz>()
                {
                    Description = $"[Edit] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }





    }
}
