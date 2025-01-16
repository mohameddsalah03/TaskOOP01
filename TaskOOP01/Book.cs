using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP01
{
    internal struct Book
    {
        string? title;
        string? author;
        string? isbn;

        public Book(string? title, string? author, string? isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
    }
}
