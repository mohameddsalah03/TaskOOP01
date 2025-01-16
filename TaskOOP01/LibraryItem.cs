using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP01
{
    internal class LibraryItem
    {
        int itemId;
        bool isAvailable;

        public LibraryItem()
        {

        }
        public LibraryItem(int itemId)
        {
            this.itemId = itemId;
        }

        public int ItemId { get; set; }
        public bool IsAvailable { get; } = true;

        public void CheckOut()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine("This Item Checked Out.");
            }
            else
            {
                Console.WriteLine("Item Checked Out Already before.");
            }
        }

        public void ReturnItem()
        {

            if (!isAvailable)
            {
                isAvailable = true;
                Console.WriteLine("Item returned successfully");
            }
            else
            {
                Console.WriteLine("Item already available.");
            }
        }
    }
}
