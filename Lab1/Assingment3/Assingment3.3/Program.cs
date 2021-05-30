using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment3._3
{
    class Program
    {
/*3: Create a console application. The application should have a Employee class with 
following
members:
BookName
AuthorName
Accept details of the Book from the user and display these details (Use Multi-Dimensional 
Array).
*/
    public class Employee
        {
            string BookName;
            String AuthorName;
        }
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the number of book which you want to add");
            i = Int32.Parse(Console.ReadLine());
            string[,] arr = new string[i,2];
            for (int j = 0; j < i; j++)
            {
                for (int k = 0; k < 1; k++)
                {
                    Console.WriteLine("Enter the " + (j + 1) + " no. Book Name");
                    arr[j, k] = Console.ReadLine();
                    Console.WriteLine("Enter the " + (j + 1) + " no. Book Author Name");
                    arr[j, (k+1)] = Console.ReadLine();
                }
            }

            Console.WriteLine("Books Details");
            for (int l = 0; l < i; l++)
            {
                for (int m = 0; m < 1; m++)
                {
                    Console.WriteLine("The Book Name = "+arr[l,m]+" And Author Name = "+arr[l,(m+1)]);
                }
            }
            Console.ReadLine();
        }
    }
}
