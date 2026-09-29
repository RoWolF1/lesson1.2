using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class ProductController : Controller
    {
        // 1. Nhận id qua Route Data: /Product/Detail/5
        // Dùng int? để kiểm tra trường hợp người dùng KHÔNG gõ số id
        public IActionResult Detail(int? id)
        {
            if (!id.HasValue)
            {
                return Content("Lỗi: Vui lòng truyền id sản phẩm trên URL. Ví dụ: /Product/Detail/5");
            }

            return Content($"Product ID = {id.Value}");
        }

        // 2. Nhận name qua Query String: /Product/Category?name=Laptop
        public IActionResult Category(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return Content("Lỗi: Vui lòng truyền tham số name trên URL. Ví dụ: /Product/Category?name=Laptop");
            }

            return Content($"Category = {name}");
        }
    }
}