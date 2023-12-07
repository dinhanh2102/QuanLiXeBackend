using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp.DbContexts;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {  
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Server is running");
        }
        [Authorize] // Thêm decorator [Authorize] để yêu cầu xác thực
        [HttpGet("ProtectedResource")]
        public IActionResult ProtectedResource()
        {
            // Tài nguyên được bảo vệ, chỉ có người dùng đã đăng nhập và cung cấp AccessToken hợp lệ mới có thể truy cập
            var username = User.Identity.Name;
            return Ok(new ApiResponse
            {
                Success = true,
                Message = "Protected resource accessed by user: " + username
            });
        }

    }
}
