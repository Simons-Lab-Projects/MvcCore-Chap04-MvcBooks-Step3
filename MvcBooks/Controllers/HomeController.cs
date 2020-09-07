using Microsoft.AspNetCore.Mvc;
using MvcBooks.Models;

namespace MvcBooks.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        public IActionResult Index()
        {
            DB db = new DB();
            ViewBag.Cats = db.cats;
            return View();
        }

        // GET: /Home/Books
        public IActionResult Books()
        {
            DB db = new DB();
            ViewBag.Books = db.books;
            return View();
        }

        // GET: /Home/BooksByCat
        public IActionResult BooksByCat()
        {
            DB db = new DB();
            ViewBag.DB = db;
            return View();
        }

        // GET: /Home/Save
        public string Save()
        {
            DB db = new DB();
            return db.Save();
        }
   }
}
