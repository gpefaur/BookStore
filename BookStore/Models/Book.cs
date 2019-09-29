using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages.Internal;
using Newtonsoft.Json;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "Book Title")]
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "The Title length should be between 2 and 50.", MinimumLength = 2)]
        public string Title { get; set; }

        public string Genre { get; set; }

        public string Authors { get; set; }

        [DataType(DataType.Currency)]
        [Range(1, 100)]
        public decimal Price { get; set; }

        [Display(Name = "Publish Date")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        public List<Book> GetBooks()
        {
            // Get all books from BD using linq and EF
            
            List<Book> books = new List<Book>();
            Book book = new Book()
            {
                Id = 1,
                Title = "The man in the high castle",
                Genre = "Alternative future",
                Price = 45,
                PublishDate = new System.DateTime(2012, 04, 23),
                Authors =  "Philip K. Dick" 
            };
            books.Add(book);

            return books;
        }

        internal Book GetUniqueBook(int id)
        {
            var book = new Book()
            {
                Id = 1,
                Title = "The man in the high castle",
                Genre = "Alternative future",
                Price = 45,
                PublishDate = new System.DateTime(2012, 04, 23),
                Authors = "Philip K. Dick"
            };
            return book;
        }

        public bool Save()
        {
            // Using context
            // Save the record, if new then set EntityState.Added
            //                  if modified then set EntityState.Modified
            // SaveChanges to the BD
            var answer = true;
            return answer;
        }
    }
}
