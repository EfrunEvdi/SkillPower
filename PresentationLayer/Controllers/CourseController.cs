using BusinessLayer.Abstract;
using DtoLayer.Dtos.CourseDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class CourseController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICourseService _courseService;

        public CourseController(UserManager<AppUser> userManager, ICourseService courseService)
        {
            _userManager = userManager;
            _courseService = courseService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateCourseDto createCourseDto)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            Course course = new Course()
            {
                CourseName = createCourseDto.CourseName,
                CourseTotalTime = createCourseDto.CourseTotalTime,
                CourseAttendee = 0,
                CourseLikes = 0,
                CourseStatus = false,
                AppUserID = user.Id
            };

            TempData["ID"] = 1;

            _courseService.TInsert(course);
            return RedirectToAction("Index", "CourseDetails");
        }
    }
}
