using BusinessLogic.Interfaces;
using Domain.Models.Course;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace SpanishWebProj.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseBL _courseBL;

        public CourseController(ICourseBL courseBL)
        {
            _courseBL = courseBL;
        }

        [HttpGet]
        public IActionResult GetCourses()
        {
            var response = _courseBL.GetCourses();
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return View("Error", $"{response.Description}");
        }
        
        
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _courseBL.DeleteCourse(id);
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return RedirectToAction("GetCourses");
            }
            return View("Error", $"{response.Description}");
        }
        [HttpPost]
        public async Task<IActionResult> Save(CourseViewModel viewModel)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                if (viewModel.Id == 0)
                {
                    byte[] imageData;
                    using (var binaryReader = new BinaryReader(viewModel.Avatar.OpenReadStream()))
                    {
                        imageData = binaryReader.ReadBytes((int)viewModel.Avatar.Length);
                    }
                    await _courseBL.Create(viewModel, imageData);
                }
                else
                {
                    await _courseBL.Edit(viewModel.Id, viewModel);
                }
            }
            return RedirectToAction("GetCourses");
        }


        [HttpGet]
        public async Task<ActionResult> GetCourse(int id, bool isJson)
        {
            var response = await _courseBL.GetCourse(id);
            if (isJson)
            {
                return Json(response.Data);
            }
            return PartialView("GetCourse", response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> GetCourse(string term)
        {
            var response = await _courseBL.GetCourse(term);
            return Json(response.Data);
        }

        [HttpPost]
        public JsonResult GetTypes()
        {
            var types = _courseBL.GetTypes();
            return Json(types.Data);
        }
    }
}