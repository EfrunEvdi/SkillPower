using DtoLayer.Dtos.AppUserDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [Authorize]
    public class MyProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public MyProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUserEditDto appUserEditDto = new AppUserEditDto();
            appUserEditDto.Name = values.Name;
            appUserEditDto.Surname = values.Surname;
            appUserEditDto.UserName = values.UserName;
            appUserEditDto.PhoneNumber = values.PhoneNumber;
            appUserEditDto.ImageUrl = values.ImageUrl;
            appUserEditDto.Email = values.Email;

            TempData["Name"] = appUserEditDto.Name;
            TempData["Surname"] = appUserEditDto.Surname;
            TempData["Image"] = appUserEditDto.ImageUrl;

            return View(appUserEditDto);
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserEditDto appUserEditDto)
        {
            if (appUserEditDto.Password == appUserEditDto.ConfirmPassword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.Name = appUserEditDto.Name;
                user.Surname = appUserEditDto.Surname;
                user.UserName = appUserEditDto.UserName;
                user.PhoneNumber = appUserEditDto.PhoneNumber;
                user.ImageUrl = "sa"; //analytic-html/img/staf/IMG_2660.JPG
                user.Email = appUserEditDto.Email;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, appUserEditDto.Password);
                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
            }

            else
            {
                return View(appUserEditDto);
            }

            return View();
        }
    }
}
