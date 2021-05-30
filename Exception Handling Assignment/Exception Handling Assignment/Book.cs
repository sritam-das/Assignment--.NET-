using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Assignment
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public double price { get; set; }

        public void display()
        {
            Console.WriteLine("Book Id : {0}\n Book Name : {1}\n Author : {2}\n Price : {3}",
                BookId,BookName,Author,price);
        }
    }
}
