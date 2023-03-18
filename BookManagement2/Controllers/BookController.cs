using BookManagement2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement2.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.AllBook);
        }

        [HttpPost]
        public IActionResult Search(int s)
        {
                var book = Repository.AllBook.Where(e => e.BookPrice == s).FirstOrDefault()!;
                return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                Repository.Create(book);
                return View("Success");
            }
            else
                return View();
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            Book book = Repository.AllBook.Where(e => e.BookID == id).FirstOrDefault()!;
            Repository.Delete(book);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            Book book = Repository.AllBook.Where(e => e.BookID == id).FirstOrDefault()!;
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book, int id)
        {
            if (ModelState.IsValid)
            {

                Repository.AllBook.Where(e => e.BookID == id).FirstOrDefault()!.BookName = book.BookName;
                Repository.AllBook.Where(e => e.BookID == id).FirstOrDefault()!.BookDesc = book.BookDesc;
                Repository.AllBook.Where(e => e.BookID == id).FirstOrDefault()!.BookPrice = book.BookPrice;
                Repository.AllBook.Where(e => e.BookID == id).FirstOrDefault()!.BookQuantity = book.BookQuantity;
                Repository.AllBook.Where(e => e.BookID == id).FirstOrDefault()!.BookImage = book.BookImage;

                return RedirectToAction("Index");
            }
            else
                return View();
        }
    }
}
