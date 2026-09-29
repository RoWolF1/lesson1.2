using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Info()
        {
            // 1. Dùng ViewBag cho Name
            ViewBag.Name = "Nguyễn Văn A";

            // 2. Dùng ViewData cho Age
            ViewData["Age"] = 20;

            // 3. Dùng Model cho Major
            Student student = new Student
            {
                Major = "CNTT"
            };

            // Truyền đối tượng student vào View
            return View(student);
        }
    }
}