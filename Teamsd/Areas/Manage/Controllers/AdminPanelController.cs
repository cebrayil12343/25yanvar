using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Teamsd.Models;

namespace Teamsd.Areas.Manage.Controllers
{
    [Area("manage")]
    public class AdminPanelController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public AdminPanelController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AdminRole()
        {
            AppUser appUser = new AppUser
            {
                FullName = "Cavad Allahverdiyev",
                UserName = "Admin"
            };
            var result = await _userManager.CreateAsync(appUser,  "admin123");
            return Ok(result);
        }
    }
}
