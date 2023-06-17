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
        public IActionResult CreateCourse()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourse(CreateCourseDto createCourseDto)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            Course course = new Course()
            {
                CourseName = createCourseDto.CourseName,
                CourseImageUrl = createCourseDto.CourseImageUrl,
                CourseDescription = createCourseDto.CourseDescription,
                CourseTotalPrice = createCourseDto.CourseTotalPrice,
                CourseTotalTime = createCourseDto.CourseTotalTime,
                CourseAttendee = 0,
                CourseLikes = 0,
                CourseStatus = false,
                AppUserID = user.Id
            };

            _courseService.TInsert(course);
            TempData["CourseID"] = course.CourseID;
            return RedirectToAction("CreateCourseDetails", "CourseDetail");
        }

        public IActionResult CourseList()
        {
            var values = _courseService.TGetCourseDetailsByCourseID();
            return View(values);
        }
    }
}
