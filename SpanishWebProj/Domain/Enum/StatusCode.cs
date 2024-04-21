using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enum
{
    public enum StatusCode
    {
        UserNotFound = 0, //user
        UserAlreadyExists = 1,

        CourseNotFound = 1,
        QuizNotFound = 2,

        OK = 200,
        InternalServerError = 500,
        BadRequest = 501,
    }
}
