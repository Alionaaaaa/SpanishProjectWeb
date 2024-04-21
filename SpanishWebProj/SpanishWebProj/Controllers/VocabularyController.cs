using BusinessLogic.Implementations;
using BusinessLogic.Interfaces;
using Domain.Entity.Vocabulary;
using Domain.Models.Vocabulary;
using Microsoft.AspNetCore.Mvc;

namespace SpanishWebProj.Controllers
{
    public class VocabularyController : Controller
    {
        private readonly IAudioLessonBL _audioLessonBL;

        public VocabularyController(IAudioLessonBL audioLessonBL)
        {
            _audioLessonBL = audioLessonBL;
        }

        [HttpGet]
        public IActionResult GetLessons()
        {
            var response = _audioLessonBL.GetAudioLessons();
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return View("Error", $"{response.Description}");

        }

        [HttpGet]
        public async Task<IActionResult> LessonDetails(int id)
        {
            var response = await _audioLessonBL.GetAudioLessonById(id);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                ViewBag.LessonId = id; // Setarea ID-ului lecției audio în ViewBag
                //var AudioEntityViewModel = response.Data; // modelul întregii lecții audio
                //ViewBag.LessonName = AudioEntityViewModel.Subject;
                var audioLessonViewModel = response.Data; // modelul întregii lecții audio
                var audioEntities = audioLessonViewModel.AudioEntity; // lista de entități audio


                return View(audioEntities);
            }

            return View("Error", $"{response.Description}");
        }

        //[HttpGet]
        //public async Task<IActionResult> LessonDetailsPractice(int id)
        //{
        //    var response = await _audioLessonBL.GetAudioLessonById(id);

        //    if (response.StatusCode == Domain.Enum.StatusCode.OK)
        //    {
        //        ViewBag.LessonId = id; // Setarea ID-ului lecției audio în ViewBag
        //        var audioLessonViewModel = response.Data; // modelul întregii lecții audio
        //        var audioEntities = audioLessonViewModel.AudioEntity; // lista de entități audio

        //        return View("LessonDetailsPractice", audioEntities); // Trimite datele către view-ul LessonDetailsPractice
        //    }

        //    return View("Error", $"{response.Description}");
        //}

        [HttpGet]
        public async Task<IActionResult> LessonDetailsPractice(int id)
        {
            var response = await _audioLessonBL.GenerateQuizQuestions(id);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                ViewBag.LessonId = id; // Setarea ID-ului lecției audio în ViewBag

                // Adăugăm răspunsurile corecte pentru fiecare întrebare în ViewData pentru a le accesa în vizualizare
                for (int i = 0; i < response.Data.Questions.Count; i++)
                {
                    var correctAnswer = response.Data.Questions[i].CorrectAnswer;
                    ViewData[$"CorrectAnswer-{i}"] = correctAnswer;
                }

                return View("LessonDetailsPractice", response.Data); // Trimite datele către view-ul LessonDetailsPractice
            }

            return View("Error", $"{response.Description}");
        }
    }
}
