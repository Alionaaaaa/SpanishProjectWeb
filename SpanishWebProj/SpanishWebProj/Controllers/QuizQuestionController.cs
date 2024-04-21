using BusinessLogic.Implementations;
using BusinessLogic.Interfaces;
using Domain.Entity.Quiz;
using Domain.Models.Quiz;
using Microsoft.AspNetCore.Mvc;
using SpanishWebProj.Controllers;
using System.Threading.Tasks;

namespace YourProject.Controllers
{
    public class QuizQuestionController : Controller
    {
        private readonly IQuizQuestionBL _quizQuestionBL;

        public QuizQuestionController(IQuizQuestionBL quizQuestionBL)
        {
            _quizQuestionBL = quizQuestionBL;
        }


        [HttpGet]
        public IActionResult AddQuestion(int quizId)
        {
            var viewModel = new QuizQuestionViewModel
            {
                QuizId = quizId // Populate the QuizId property in the view model
            };

            return View(viewModel); // Pass the view model to the view
        }

        [HttpPost]
        public async Task<IActionResult> AddQuestion(int quizId, QuizQuestionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _quizQuestionBL.Create(quizId, model);
                if (response.StatusCode == Domain.Enum.StatusCode.OK)
                {
                    return RedirectToAction("QuizDetails", "Quiz", new { id = quizId });
                }
            }

            return View(model);
        }

        // [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id, int quizId)
        {
            var response = await _quizQuestionBL.Delete(id);
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                // Redirect to QuizDetails with the correct quiz ID
                return RedirectToAction("QuizDetails", "Quiz", new { id = quizId });
            }
            return View("Error", $"{response.Description}");
        }





    }

}