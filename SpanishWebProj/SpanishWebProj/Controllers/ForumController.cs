using BusinessLogic.Interfaces.IForumBL;
using Microsoft.AspNetCore.Mvc;

namespace SpanishWebProj.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForumTopicBl _forumTopicBl;
        public ForumController(IForumTopicBl forumTopicBl) 
        { 
            _forumTopicBl = forumTopicBl;

        }
        public IActionResult GetSubjects()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetTopics()
        {
            var response = _forumTopicBl.GetAllTopics();
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return View("Error", $"{response.Description}");
        }

    }
}
