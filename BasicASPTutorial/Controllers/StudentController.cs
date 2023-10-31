using Microsoft.AspNetCore.Mvc;

namespace BasicASPTutorial.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return Content("คะแนนสอบวิชาคอม");
        }
        public IActionResult Details()
        {
            return Content("ราลละเอียดคะแนนสอบ");
        }
        public IActionResult ShowScore(int id) {
            return Content($"คะแนนสอบของนักเรียน เลขที่ {id}");
        }
    }
}
