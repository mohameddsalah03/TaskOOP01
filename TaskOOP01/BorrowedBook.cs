using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP01
{
    internal class BorrowedBook : LibraryItem
    {
        Book bookDetails;
        string? borrowerName;
        DateTime borrowedDate;

        public Book BookDetails { get; set; }
        public string? BorrowerName { get; set; }
        public DateTime BorrowedDate { get; set; }


        public BorrowedBook(int itemId, Book bookDetails, string? borrowerName, DateTime borrowedDate) : base(itemId)
        {
            this.bookDetails = bookDetails;
            this.borrowerName = borrowerName;
            this.borrowedDate = borrowedDate;
        }

        public int CalculateBorrowDuration()
        {
            return (DateTime.Now - borrowedDate).Days;
        }
    }
}
