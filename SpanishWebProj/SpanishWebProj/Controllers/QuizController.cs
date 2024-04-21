using BusinessLogic.Implementations;
using BusinessLogic.Interfaces;
using Domain.Entity.Quiz;
using Domain.Models.Quiz;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SpanishWebProj.Controllers
{
    public class QuizController : Controller
    {
        private readonly IQuizBL _quizBL;


        public QuizController(IQuizBL quizBL)
        {
            _quizBL = quizBL;
        }


        [HttpGet]
        public IActionResult GetQuizes()
        {
            var response = _quizBL.GetQuizes();
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return View("Error", $"{response.Description}");

        }


        public async Task<IActionResult> QuizDetails(int id)
        {
            var response = await _quizBL.GetQuizById(id);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return View("Error", $"{response.Description}");
        }

        // [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _quizBL.DeleteQuiz(id);
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return RedirectToAction("GetQuizes");
            }
            return View("Error", $"{response.Description}");
        }


        [HttpGet]
        public IActionResult CreateQuiz()
        {
            return View(new QuizViewModel()); // Pass an empty view model to the view for creating a new quiz
        }


        [HttpPost]
        public async Task<IActionResult> CreateQuiz(QuizViewModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _quizBL.CreateQuiz(model);
                if (response.StatusCode == Domain.Enum.StatusCode.OK)
                {
                    // Redirect to the action where you display quizzes or perform other actions
                    return RedirectToAction("GetQuizes");
                }
            }

            // If the ModelState is not valid, return the view with validation errors
            return View(model);
        }

        //[HttpPost]
        //public async Task<IActionResult> SubmitAnswers(int quizId, Dictionary<int, string> answers)
        //{
        //    try
        //    {
        //        // Verificăm dacă există răspunsuri pentru a evita excepțiile
        //        if (answers == null || !answers.Any())
        //        {
        //            throw new ArgumentException("No answers provided.");
        //        }

        //        // Calculăm scorul quizului utilizând metoda din IQuizBL
        //        var totalScore = await _quizBL.CalculateQuizScore(quizId, answers);

        //        // Obținem modelul de quiz utilizând metoda GetQuizById
        //        var quizResponse = await _quizBL.GetQuizById(quizId);
        //        if (quizResponse.StatusCode != Domain.Enum.StatusCode.OK)
        //        {
        //            return View("Error", $"{quizResponse.Description}");
        //        }
        //        var quizViewModel = quizResponse.Data;

        //        // Setăm scorul calculat în modelul de quiz
        //        quizViewModel.TotalScore = totalScore;

        //        // Returnăm pagina QuizDetails cu scorul afișat
        //        return View("QuizDetails", quizViewModel);
        //    }
        //    catch (Exception ex)
        //    {
        //        // În caz de eroare, afișăm o eroare generică sau facem altă manipulare a erorii
        //        return View("Error", ex.Message);
        //    }
        //}

    }
}
