using GroupProjectCISS411.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupProjectCISS411.Controllers
{
    [Authorize(Roles="Admin")]
    public class AdminController : Controller
    {
        // GET: /<controller>/
        private readonly ApplicationDbContext db;
        public AdminController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllLesson()
        {
            return View(db.Lessons);
        }
        public IActionResult AddLesson()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddLesson(Lesson lesson)
        {
            db.Add(lesson);
            await db.SaveChangesAsync();
            return RedirectToAction("AllLesson");
        }
    }
}
