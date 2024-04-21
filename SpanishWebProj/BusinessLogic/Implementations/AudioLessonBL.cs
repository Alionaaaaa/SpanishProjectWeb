using BusinessLogic.Interfaces;
using DAL.Interfaces;
using DAL.Repositories;
using Domain.Entity.Vocabulary;
using Domain.Enum;
using Domain.Models.Vocabulary;
using Domain.Response;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Implementations
{
    public class AudioLessonBL : IAudioLessonBL
    {
        private readonly IBaseRepository<AudioLesson> _audioLessonRepository;
        public AudioLessonBL(IBaseRepository<AudioLesson> audioLessonRepository)
        {
            _audioLessonRepository = audioLessonRepository;
        }

        public IBaseResponse<List<AudioLesson>> GetAudioLessons()
        {
            try
            {
                // Recuperați lista de lecții audio
                var audioLessons = _audioLessonRepository.GetAll().ToList();

                // Parcurgeți fiecare lecție audio pentru a verifica și actualiza ImagePath-ul
                foreach (var lesson in audioLessons)
                {
                    if (string.IsNullOrEmpty(lesson.ImagePath))
                    {
                        // Setează ImagePath la "/images/0.jpg" dacă este null sau gol
                        lesson.ImagePath = "/images/0img.jpg";
                    }
                }

                if (!audioLessons.Any())
                {
                    return new BaseResponse<List<AudioLesson>>()
                    {
                        Description = "Nu sunt găsite lecții",
                        StatusCode = StatusCode.OK
                    };
                }

                return new BaseResponse<List<AudioLesson>>()
                {
                    Data = audioLessons,
                    StatusCode = StatusCode.OK
                };

            }
            catch (Exception ex)
            {
                return new BaseResponse<List<AudioLesson>>()
                {
                    Description = $"[GetAudioLesson] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }


        public async Task<IBaseResponse<AudioLessonViewModel>> GetAudioLessonById(int id)
        {
            try
            {
                var audioLesson = await _audioLessonRepository.GetAll()
                    .Include(q => q.AudioEntity) // Include related AudioEntity
                    .FirstOrDefaultAsync(x => x.Id == id);

                if (audioLesson == null)
                {
                    return new BaseResponse<AudioLessonViewModel>()
                    {
                        Description = "Nu sunt găsite lecții",
                        StatusCode = StatusCode.QuizNotFound
                    };
                }

                var audioLessonViewModel = new AudioLessonViewModel()
                {
                    Id = audioLesson.Id,
                    Subject = audioLesson.Subject,
                    ImagePath = audioLesson.ImagePath,
                    Level = audioLesson.Level,

                    AudioEntity = audioLesson.AudioEntity.Select(q => new AudioEntity
                    {
                        Id = q.Id,
                        TextSpanish = q.TextSpanish,
                        TextRomanian = q.TextRomanian,
                        SoundSpanishPath = q.SoundSpanishPath,
                        SoundRomanianPath = q.SoundRomanianPath,
                        ImagePath = q.ImagePath,

                    }).ToList()
                };

                return new BaseResponse<AudioLessonViewModel>()
                {
                    Data = audioLessonViewModel,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<AudioLessonViewModel>()
                {
                    Description = $"[GetAudioLessonById] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }


        public async Task<IBaseResponse<AudioQuizViewModel>> GenerateQuizQuestions(int id)
        {
            try
            {
                var audioLesson = await _audioLessonRepository.GetAll()
                   .Include(q => q.AudioEntity) // Include related AudioEntity
                   .FirstOrDefaultAsync(x => x.Id == id);

                if (audioLesson == null)
                {
                    return new BaseResponse<AudioQuizViewModel>()
                    {
                        Description = "Lecția nu a fost găsită",
                        StatusCode = StatusCode.QuizNotFound
                    };
                }

                var quizViewModel = new AudioQuizViewModel
                {
                    LessonSubject = audioLesson.Subject,
                    LessonImagePath = audioLesson.ImagePath,
                    
                    Questions = new List<AudioQuizQuestionViewModel>()
                };

                // Generare întrebări pentru quiz
                foreach (var audioEntity in audioLesson.AudioEntity)
                {
                    var question = new AudioQuizQuestionViewModel
                    {
                        QuestionText = audioEntity.TextSpanish,
                        ImagePath = audioEntity.ImagePath ?? "/sounds/img/noimg.jpg",
                        SoundSpanishPath = audioEntity.SoundSpanishPath,
                        SoundRomanianPath = audioEntity.SoundRomanianPath,


                        CorrectAnswer = audioEntity.TextRomanian,
                        Options = audioLesson.AudioEntity
                            .Where(a => a.Id != audioEntity.Id)
                            .Select(a => a.TextRomanian)
                            .OrderBy(a => Guid.NewGuid())
                            .Take(3)
                            .ToList()
                    };

                    question.Options.Add(audioEntity.TextRomanian); // Adăugăm răspunsul corect
                    question.Options = question.Options.OrderBy(o => Guid.NewGuid()).ToList(); // Amestecăm opțiunile

                    quizViewModel.Questions.Add(question);
                }

                return new BaseResponse<AudioQuizViewModel>()
                {
                    Data = quizViewModel,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<AudioQuizViewModel>()
                {
                    Description = $"Eroare la generarea quiz-ului: {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }




    }
}