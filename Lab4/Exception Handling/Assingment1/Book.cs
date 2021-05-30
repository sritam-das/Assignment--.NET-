using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment1
{
    class Book:Exception
    {
        

        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }


        public Book()
        {

        }

        public Book(int bookID, string bookName, string author, string genre, double price)
        {

            if (bookID < 1)
                throw new ArgumentOutOfRangeException("BookID", "BookID must be greater than zero");
            else
            {
                BookID = bookID;
            }
            BookName = bookName;
            Author = author;
            Genre = genre;
            if (price < 1)
                throw new ArgumentOutOfRangeException("Price", "Book price must be greater than 0 zero");
            else
            {
                Price = price;
            }
            
        }

       public void ToString()
        {
            Console.WriteLine("BookID = "+BookID+" Book Name = "+BookName+" Author = "+Author+" Price = "+Price);
        }

    }
}
