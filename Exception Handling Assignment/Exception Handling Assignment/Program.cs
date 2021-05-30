using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exception_Handling_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookObj = new Book();
            while(true)
            {
                Console.WriteLine("**********************BOOk SHOP***************************");
                Console.WriteLine("1. BOOK ID\n2. BOOK NAME\n3. PRICE\n4. AUTHOR");
                Console.WriteLine("Enter your choice:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice) 
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Enter the Book ID :");
                            bookObj.BookId = int.Parse(Console.ReadLine());
                            if (bookObj.BookId == 0 || bookObj.BookId < 0)
                            {
                               
                                throw new ArgumentException(); 
                            }
                            else
                            {
                                Console.WriteLine("Reqd book id is {0}:", bookObj.BookId);
                            }

                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Book Id must be greater than zero");  
                        }
                        break;

                    case 2:
                        try
                        {
                            Console.WriteLine("Enter the Book Name :");
                            bookObj.BookName =Console.ReadLine();
                            if(bookObj.BookName=="")
                            {
                                throw new ArgumentNullException();
                            }
                            else
                            {
                                Console.WriteLine(bookObj.BookName);
                            }
                        }
                        catch (ArgumentNullException)
                        {
                            Console.WriteLine("Book must have a name");
                        }
                        break;

                    case 3:
                        try
                        {
                            Console.WriteLine("Enter the Book price :");
                            bookObj.price = int.Parse(Console.ReadLine());
                            if (bookObj.price == 0 || bookObj.price < 0)
                            {
                                throw new ArgumentException();
                            }
                            else
                            {
                                Console.WriteLine("Reqd book price is {0}:", bookObj.price);
                            }

                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Book price must be greater than zero");
                        }
                        break;

                    case 4:
                        try
                        {
                            Console.WriteLine("Enter the Author Name :");
                            bookObj.Author = Console.ReadLine();
                            if (bookObj.Author == "")
                            {
                                throw new CustomException("There must be a Author Name");
                            }
                            else
                            {
                                Console.WriteLine(bookObj.Author);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 10:
                        return;
                }

                
              

            }
          

        }
    }
}
