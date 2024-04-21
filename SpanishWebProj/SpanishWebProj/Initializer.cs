using BusinessLogic.Implementations;
using BusinessLogic.Implementations.ForumBl;
using BusinessLogic.Interfaces;
using BusinessLogic.Interfaces.IForumBL;
using DAL.Interfaces;
using DAL.Repositories;
using DAL.Repositories.ForumRepository;
using Domain.Entity;
using Domain.Entity.Forum;
using Domain.Entity.Quiz;
using Domain.Entity.Vocabulary;
using Domain.Entity.Worksheet;

namespace SpanishWebProj
{
    public static class Initializer
    {
        public static void InitializeRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<Course>, CourseRepository>();
            services.AddScoped<IBaseRepository<User>, UserRepository>();
            services.AddScoped<IBaseRepository<Profile>, ProfileRepository>();
            services.AddScoped<IBaseRepository<Quiz>, QuizRepository>();
            services.AddScoped<IBaseRepository<QuizQuestion>, QuizQuestionRepository>();
            services.AddScoped<IBaseRepository<AudioLesson>, VocabularyRepository>();
            services.AddScoped<IBaseRepository<Worksheet>, WorksheetRepository>();
            services.AddScoped<IBaseRepository<WorksheetCategory>, WorksheetCategoryRepository>();
            services.AddScoped<IBaseRepository<ForumCategory>, ForumCategoryRepository>();
            services.AddScoped<IBaseRepository<ForumTopic>, ForumTopicRepository>();
            services.AddScoped<IBaseRepository<ForumMessage>, ForumMessageRepository>();
        }
        
        public static void InitializeServices(this IServiceCollection services)
        {
            services.AddScoped<ICourseBL, CourseBL>();
            services.AddScoped<IAccountBL, AccountBL>();
            services.AddScoped<IUserBL, UserBL>();
            services.AddScoped<IProfileBL, ProfileBL>();
            services.AddScoped<IQuizBL, QuizBL>();
            services.AddScoped<IQuizQuestionBL, QuizQuestionBL>();
            services.AddScoped<IAudioLessonBL, AudioLessonBL>();
            services.AddScoped<IWorksheetBL, WorksheetBL>();
            services.AddScoped<IForumTopicBl, ForumTopicBl>();

        }
    }
}
