using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Teamsd.Areas.Manage.ViewModels;
using Teamsd.Models;

namespace Teamsd.Areas.Manage.Controllers
{
    [Area("manage")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _user;

        public AccountController(UserManager<AppUser> user)
        {
            _user = user;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AdminLogin adminLogin)
        {
            if (!ModelState.IsValid) return View();
            AppUser appUser = await _user.FindByNameAsync(adminLogin.UserName);

            if(appUser == null)
            {
                ModelState.AddModelError("", "username or password is incorret");
            }

            return Ok(adminLogin);
        }
    }
}
