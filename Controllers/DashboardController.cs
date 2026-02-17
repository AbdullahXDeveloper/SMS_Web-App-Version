using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;  
using SMS_Web_App_Version.Data;

namespace SMS_Web_App_Version.Controllers
{
    public class DashboardController : Controller
    {
        private readonly AppDBContext _context;

        public DashboardController(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var totalStudents = await _context.students.CountAsync();
            var recentStudents = await _context.students
                                               .OrderByDescending(s => s.Id)
                                               .Take(5)
                                               .ToListAsync();

            ViewBag.TotalStudents = totalStudents;

            return View(recentStudents);
        }
    }
}
