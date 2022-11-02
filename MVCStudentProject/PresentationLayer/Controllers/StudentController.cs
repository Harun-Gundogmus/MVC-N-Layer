using BusinessLayer.Abstract;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Schema;

namespace PresentationLayer.Controllers
{
    public class StudentController : Controller
    {
        IStudentService _student;
        public StudentController(IStudentService student)
        {
            _student = student;
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Student student)
        {
            var result = _student.AddStudent(student);
            return RedirectToAction("Listele");
        }



        [HttpGet]
        public IActionResult Listele()
        {
            var result = _student.ListAddStudent();
            return View(result);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
