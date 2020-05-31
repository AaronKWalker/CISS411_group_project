using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupProjectCISS411.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupProjectCISS411.Controllers
{
    [Authorize(Roles ="Coach")]
    public class CoachController : Controller
    {
        // GET: /<controller>/
        private readonly ApplicationDbContext db;
        public CoachController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddProfile()
        {
            var currentUserId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            Coach coach = new Coach();
            if(db.Coaches.Any(i=>i.UserId == currentUserId))
            {
                coach = db.Coaches.FirstOrDefault(i => i.UserId == currentUserId);
            }
            else
            {
                coach.UserId = currentUserId;
            }
            return View(coach);
        }
        [HttpPost]
        public async Task<IActionResult> AddProfile(Coach coach)
        {
            var currentUserId = this.User.FindFirst
            (ClaimTypes.NameIdentifier).Value;
            if (db.Coaches.Any
            (i => i.UserId == currentUserId))
            {
                var coachToUpdate = db.Coaches.FirstOrDefault
                (i => i.UserId == currentUserId);
                coachToUpdate.CoachName =
                coach.CoachName;
                coachToUpdate.CoachPhone =
                coach.CoachPhone;
                db.Update(coachToUpdate);
            }
            else
            {
                db.Add(coach);
            }
            await db.SaveChangesAsync();
            return View("Index");
        }
        public IActionResult AddSession()
        {
            Session session = new Session();
            var currentUserId = this.User.FindFirst
                (ClaimTypes.NameIdentifier).Value;
            session.CoachId = db.Coaches.
                SingleOrDefault(i => i.UserId ==
                currentUserId).CoachId;
            return View(session);
        }
        [HttpPost]
        public async Task<IActionResult> AddSession(Session session)
        {
            db.Add(session);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", "Coach");
        }
        public async Task<IActionResult> SessionByCoach()
        {
            var currentUserId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var CoachId = db.Coaches.SingleOrDefault(i => i.UserId == currentUserId).CoachId;
            var session = await db.Sessions.Where(i =>
            i.CoachId == CoachId).ToListAsync();
            return View(session);
        }
        public async Task<IActionResult> PostReport(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var allSwimmers = await db.Enrollments.Include
                (c => c.Session).Where(c => c.SessionId == id)
                .ToListAsync();
            if (allSwimmers == null)
            {
                return NotFound();
            }
            return View(allSwimmers);
        }
        [HttpPost]
        public IActionResult PostReport(List<Enrollment> enrollments)
        {
            foreach (var enrollment in enrollments)
            {
                var er = db.Enrollments.Find(enrollment.EnrollmentId);
                er.Report = enrollment.Report;
            }
            db.SaveChanges();
            return RedirectToAction("SessionByCoach");
        }
    }
}
