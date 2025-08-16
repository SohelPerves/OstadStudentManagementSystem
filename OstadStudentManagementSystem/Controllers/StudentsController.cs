using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OstadStudentManagementSystem.Data;
using OstadStudentManagementSystem.Models;
using System.Linq;

namespace OstadStudentManagementSystem.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Display students > 18
        public async Task<IActionResult> Index(string searchString)
        {
            var students = from s in _context.Students
                           select s;

            // Filter by name
            if (!string.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.FirstName.Contains(searchString)
                                            || s.LastName.Contains(searchString));
            }

            // Only show age > 18
            students = students.Where(s => s.Age > 18);

            // Student count
            ViewBag.StudentCount = students.Count();

            return View(await students.ToListAsync());
        }

        // Create - Add new student
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
    }
}
