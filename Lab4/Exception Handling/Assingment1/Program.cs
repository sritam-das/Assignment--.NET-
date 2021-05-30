using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter the Book ID ");
                int id = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Book Name");
                string Bname = Console.ReadLine();
                if (Bname.Length < 1)
                {
                    throw new AutherException("Book Name is mandatory");
                }

                Console.WriteLine("Enter the Author Name");
                string Aname = Console.ReadLine();
                if (Aname.Length < 1)
                {
                    throw new AutherException("Author Name is mandatory");
                }

                Console.WriteLine("Enter the Book Gener");
                string Gener = Console.ReadLine();

                Console.WriteLine("Enter the Book Price ");
                Double Bprice = double.Parse(Console.ReadLine());
                Book b = new Book(id, Bname, Aname, Gener, Bprice);
                b.ToString();
                // Book b2 = new Book();
                //b2.Author = Console.ReadLine();
                //b2.BookID = Console.Read();
            }
            catch (AutherException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {

                Console.WriteLine("Error: {0}", outOfRange.Message);
            }
            finally
            {
                Console.WriteLine("Program ended");
            }
            Console.ReadLine();


        }
    }
}
