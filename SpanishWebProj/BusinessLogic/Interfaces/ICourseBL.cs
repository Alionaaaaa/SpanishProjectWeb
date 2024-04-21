using Domain.Entity;
using Domain.Models.Course;
using Domain.Response;

namespace BusinessLogic.Interfaces
{
    public interface ICourseBL
    {
        BaseResponse<Dictionary<int, string>> GetTypes();

        IBaseResponse<List<Course>> GetCourses();

        Task<IBaseResponse<CourseViewModel>> GetCourse(long id);

        Task<BaseResponse<Dictionary<long, string>>> GetCourse(string term);

        Task<IBaseResponse<Course>> Create(CourseViewModel Course, byte[] imageData);

        Task<IBaseResponse<bool>> DeleteCourse(long id);

        Task<IBaseResponse<Course>> Edit(long id, CourseViewModel model);
    }
}
