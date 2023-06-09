using BusinessLayer.Abstract;
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

        public CourseDetailController(UserManager<AppUser> userManager, ICourseDetailService courseDetailService, ITeacherService teacherService)
        {
            _userManager = userManager;
            _courseDetailService = courseDetailService;
            _teacherService = teacherService;
        }

        [HttpGet]
        public IActionResult Index()
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
        public async Task<IActionResult> Index(CourseDetail courseDetail)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            courseDetail.AppUserID = user.Id;
            _courseDetailService.TInsert(courseDetail);
            return RedirectToAction("asas");
        }
    }
}
