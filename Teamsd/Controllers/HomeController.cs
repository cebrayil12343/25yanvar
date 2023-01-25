using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Teamsd.Models;

namespace Teamsd.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _data;

        public HomeController(DataContext data)
        {
                _data = data;
        }

        public IActionResult Index()
        {
            List<Team> TeamHome = _data.TeamDB.ToList();
            return View(TeamHome);
        }

    }
}