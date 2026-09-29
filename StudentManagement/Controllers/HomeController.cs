using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/Index
        public IActionResult Index()
        {
            return Content("Welcome to ASP.NET MVC");
        }

        // GET: /Home/About
        public IActionResult About()
        {
            // Điền thông tin cá nhân của bạn
            return Content("Sinh viên: Nguyễn Văn A - MSSV: 12345678");
        }

        // GET: /Home/Contact
        public IActionResult Contact()
        {
            // Điền email của bạn
            return Content("Email sinh viên: nguyenvana@student.edu.vn");
        }
    }
}