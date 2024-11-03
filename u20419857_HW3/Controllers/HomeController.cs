using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using u20419857_HW3.Models;

namespace u20419857_HW3.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private LibraryEntities db = new LibraryEntities();

        public HomeController(LibraryEntities context)
        {
            db = context;
        }

        public async Task<ActionResult> Index()
        {
            var students = await db.students.ToListAsync();
            var books = await db.books.ToListAsync();
            return View((students, books));
        }

        [HttpPost]
        public async Task<ActionResult> CreateStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                db.students.Add(student);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

    }
}
