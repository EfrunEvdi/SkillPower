using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PresentationLayer.Controllers
{
    public class CourseDetailController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICourseDetailService _courseDetailService;
        private readonly ITeacherService _teacherService;

        Context context = new Context();

        public CourseDetailController(UserManager<AppUser> userManager, ICourseDetailService courseDetailService, ITeacherService teacherService)
        {
            _userManager = userManager;
            _courseDetailService = courseDetailService;
            _teacherService = teacherService;
        }

        [HttpGet]
        public IActionResult CreateCourseDetails()
        {
            List<SelectListItem> TeacherValue = (from x in _teacherService.TGetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.TeacherName,
                                                     Value = x.TeacherID.ToString(),

                                                 }).ToList();

            ViewBag.TV = TeacherValue;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourseDetails(CourseDetail courseDetail)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            courseDetail.AppUserID = user.Id;
            courseDetail.CourseID = Convert.ToInt32(TempData["CourseID"]);
            _courseDetailService.TInsert(courseDetail);
            return RedirectToAction("CreateCourseDetails", "CourseDetail");
        }

        public IActionResult CourseDetailList(int id, Course course)
        {
            var values = _courseDetailService.TGetListByCourseID(id);
            ViewBag.ImageUrl = context.Courses.Where(x => x.CourseID == id).Select(y => y.CourseImageUrl).FirstOrDefault();
            ViewBag.CourseName = context.Courses.Where(x => x.CourseID == id).Select(y => y.CourseName).FirstOrDefault();
            ViewBag.Attende = context.Courses.Where(x => x.CourseID == id).Select(y => y.CourseAttendee).FirstOrDefault();
            ViewBag.Like = context.Courses.Where(x => x.CourseID == id).Select(y => y.CourseLikes).FirstOrDefault();
            ViewBag.Description = context.Courses.Where(x => x.CourseID == id).Select(y => y.CourseDescription).FirstOrDefault();

            ViewBag.TotalPrice = context.CourseDetails.Where(x => x.CourseID == id).Select(y => y.CoursePrice).Sum();

            return View(values);
        }
    }
}
