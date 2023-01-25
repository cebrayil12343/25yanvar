using Microsoft.AspNetCore.Mvc;
using Teamsd.Helpers;
using Teamsd.Models;

namespace Teamsd.Areas.Manage.Controllers
{
    [Area("manage")]
    public class TeamController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly DataContext _dataContext;

        public TeamController(DataContext dataContext, IWebHostEnvironment env)
        {
            _env = env; 
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
            List<Team> teams = _dataContext.TeamDB.ToList();
            return View(teams);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Team team)
        {
            if (!ModelState.IsValid) return NotFound();

            team.Image = FileMnager.SaveImage( _env.WebRootPath, "Upload\\Teamss", team.ImageFile);

            _dataContext.TeamDB.Add(team);
            _dataContext.SaveChanges();
            return RedirectToAction("index");
        }
        
        public IActionResult Update(int Id)
        {
            if (!ModelState.IsValid) return NotFound();
            Team teamId = _dataContext.TeamDB.Find(Id);
            if (teamId == null) return NotFound();

            _dataContext.SaveChanges();
            return View(teamId);
        }
        [HttpPost]
        public IActionResult Update(Team team)
        {
            Team teamEx = _dataContext.TeamDB.Find(team.Id);
            if (!ModelState.IsValid) return NotFound();
            if(teamEx == null) return NotFound();

            if(team.ImageFile != null)
            {
                string name = FileMnager.SaveImage(_env.WebRootPath, "Upload\\Teamss",team.ImageFile);

                FileMnager.DeleteImage(_env.WebRootPath, "Upload\\Teamss", teamEx.Image);
                teamEx.Image = name;
            }

            teamEx.Professeion = team.Professeion;
            teamEx.Name = team.Name;
            teamEx.Facebook = team.Facebook;
            teamEx.Instagram = team.Instagram;
            teamEx.Twiter = team.Twiter;


            
            _dataContext.SaveChanges();
            return RedirectToAction("index");

        }

        public IActionResult Delete(int Id)
        {
            
            Team teamExDLT = _dataContext.TeamDB.FirstOrDefault(x => x.Id == Id);
            if(teamExDLT == null) return NotFound(); 
            
            if(teamExDLT.ImageFile != null)
            {
                FileMnager.DeleteImage(_env.WebRootPath, "Upload\\Teamss", teamExDLT.Image);
            }

            _dataContext.TeamDB.Remove(teamExDLT);
            _dataContext.SaveChanges();
            return RedirectToAction("index");
        }


    }
}
