using Practice01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice01.Controllers
{
    public class BookController : Controller
    {
        List<Book> books = new List<Book>()
        {
            new Book()
            {   
                BookId  = "P12546",
                Title   = "Kungfu Panda",
                Author  = "Thanh Hai",
                Price   = 50000,
                Picture = "Content/image/books/01.jpg"
            },
            new Book()
            {
                BookId  = "P47573",
                Title   = "Silicon Valey",
                Author  = "American",
                Price   = 451000,
                Picture = "Content/image/books/02.jpeg"
            },
        };
        // GET: Book
        public ActionResult Index()
        {
            ViewBag.books = books;
            return View();
        }
        public JsonResult GetBooksJson()
        {
            return Json(books,JsonRequestBehavior.AllowGet);
        }
    }
}