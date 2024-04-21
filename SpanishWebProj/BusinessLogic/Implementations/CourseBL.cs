using BusinessLogic.Interfaces;
using DAL.Interfaces;
using Domain.Entity;
using Domain.Enum;
using Domain.Extensions;
using Domain.Response;
using Domain.Models.Course;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Implementations
{
    public class CourseBL : ICourseBL
    {
        private readonly IBaseRepository<Course> _courseRepository;

        public CourseBL(IBaseRepository<Course> courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public BaseResponse<Dictionary<int, string>> GetTypes()
        {
            try
            {
                var types = ((TypeCourse[])Enum.GetValues(typeof(TypeCourse)))
                    .ToDictionary(k => (int)k, t => t.GetDisplayName());

                return new BaseResponse<Dictionary<int, string>>()
                {
                    Data = types,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Dictionary<int, string>>()
                {
                    Description = ex.Message,
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
        

        public async Task<IBaseResponse<CourseViewModel>> GetCourse(long id)
        {
            try
            {
                var course = await _courseRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);
                if (course == null)
                {
                    return new BaseResponse<CourseViewModel>()
                    {
                        Description = "Пользователь не найден",
                        StatusCode = StatusCode.UserNotFound
                    };
                }

                var data = new CourseViewModel()
                {
                    Description = course.Description,
                    Name = course.Name,
                    TypeCourse = course.TypeCourse.GetDisplayName(),
                    Image = course.Avatar,
                };

                return new BaseResponse<CourseViewModel>()
                {
                    StatusCode = StatusCode.OK,
                    Data = data
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<CourseViewModel>()
                {
                    Description = $"[GetCourse] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }


        public async Task<BaseResponse<Dictionary<long, string>>> GetCourse(string term)
        {
            var baseResponse = new BaseResponse<Dictionary<long, string>>();
            try
            {
                var courses = await _courseRepository.GetAll()
                    .Select(x => new CourseViewModel()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Description = x.Description,
                        TypeCourse = x.TypeCourse.GetDisplayName()
                    })
                    .Where(x => EF.Functions.Like(x.Name, $"%{term}%"))
                    .ToDictionaryAsync(x => x.Id, t => t.Name);

                baseResponse.Data = courses;
                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<Dictionary<long, string>>()
                {
                    Description = ex.Message,
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
       

        public async Task<IBaseResponse<Course>> Create(CourseViewModel model, byte[] imageData)
        {
            try
            {
                var course = new Course()
                {
                    Name = model.Name,
                    Description = model.Description,
                    TypeCourse = (TypeCourse)Convert.ToInt32(model.TypeCourse),
                    Avatar = imageData
                };
                await _courseRepository.Create(course);

                return new BaseResponse<Course>()
                {
                    StatusCode = StatusCode.OK,
                    Data = course
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Course>()
                {
                    Description = $"[Create] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }


        public async Task<IBaseResponse<bool>> DeleteCourse(long id)
        {
            try
            {
                var course = await _courseRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);
                if (course == null)
                {
                    return new BaseResponse<bool>()
                    {
                        Description = "User not found",
                        StatusCode = StatusCode.UserNotFound,
                        Data = false
                    };
                }

                await _courseRepository.Delete(course);

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
                    Description = $"[DeleteCourse] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }


        public async Task<IBaseResponse<Course>> Edit(long id, CourseViewModel model)
        {
            try
            {
                var course = await _courseRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);
                if (course == null)
                {
                    return new BaseResponse<Course>()
                    {
                        Description = "Course not found",
                        StatusCode = StatusCode.CourseNotFound
                    };
                }

                course.Description = model.Description;
                course.Name = model.Name;

                await _courseRepository.Update(course);


                return new BaseResponse<Course>()
                {
                    Data = course,
                    StatusCode = StatusCode.OK,
                };
                // TypeCourse
            }
            catch (Exception ex)
            {
                return new BaseResponse<Course>()
                {
                    Description = $"[Edit] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }


        public IBaseResponse<List<Course>> GetCourses()
        {
            try
            {
                var course = _courseRepository.GetAll().ToList();
                if (!course.Any())
                {
                    return new BaseResponse<List<Course>>()
                    {
                        Description = "Найдено 0 элементов",
                        StatusCode = StatusCode.OK
                    };
                }

                return new BaseResponse<List<Course>>()
                {
                    Data = course,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<List<Course>>()
                {
                    Description = $"[GetCourse] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }

}
