using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BooksController : Controller
    {
        private Book book = new Book();
        public IActionResult Index()
        {
            ViewBag.Lista = book.GetBooks();
            return View();
        }

        public IActionResult Details()
        {
            // Here would be the code to fetch the books details from the DB
            Book book = new Book()
            {
                Id = 1,
                Title = "The man in the high castle",
                Genre = "Alternative future",
                Price = 45,
                PublishDate = new System.DateTime(2012, 04, 23),
                Authors = "Philip K. Dick"
            };

            return View(book);
        }

        public IActionResult Edit(int id)
        {
           book = book.GetUniqueBook(id);

            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(Book eBook)
        {
            if (ModelState.IsValid)
            {
                // Logic to add the book to DB
                var response = eBook.Save();
                if (response) return RedirectToAction("Index");

            }

            return Json(eBook);
        }
    }
}