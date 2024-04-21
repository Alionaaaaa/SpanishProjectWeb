using BusinessLogic.Interfaces;
using Domain.Models.Profile;
using Microsoft.AspNetCore.Mvc;

namespace SpanishWebProj.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IProfileBL _profileBL;

        public ProfileController(IProfileBL profileBL)
        {
            _profileBL = profileBL;
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProfileViewModel model)
        {
            ModelState.Remove("Id");
            ModelState.Remove("UserName");
            if (ModelState.IsValid)
            {
                var response = await _profileBL.Save(model);
                if (response.StatusCode == Domain.Enum.StatusCode.OK)
                {
                    return Json(new { description = response.Description });
                }
            }
            return StatusCode(StatusCodes.Status500InternalServerError);
        }

        public async Task<IActionResult> ProfileDetail()
        {
            var userName = User.Identity.Name;
            var response = await _profileBL.GetProfile(userName);
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return View();
        }
    }
}