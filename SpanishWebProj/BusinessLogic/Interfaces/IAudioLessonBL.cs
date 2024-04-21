using Domain.Entity.Vocabulary;
using Domain.Models.Quiz;
using Domain.Models.Vocabulary;
using Domain.Response;

namespace BusinessLogic.Interfaces
{
    public interface IAudioLessonBL
    {
        IBaseResponse<List<AudioLesson>> GetAudioLessons();
        Task<IBaseResponse<AudioLessonViewModel>> GetAudioLessonById(int id);
        Task<IBaseResponse<AudioQuizViewModel>> GenerateQuizQuestions(int lessonId);
    }
}
