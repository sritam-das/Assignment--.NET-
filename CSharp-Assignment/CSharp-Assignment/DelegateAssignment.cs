using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment
{
    class DelegateAssignment
    {
        public static void Square(int num)
        {
            Console.WriteLine("The Square of the reqd number is :" + (num*num));
        }

        public static void Cube(int num)
        {
            Console.WriteLine("The Cube of the reqd number is :" + (num*num*num));
        }

        public static void SquareRoot(int num)
        {
            Console.WriteLine("The squareRoot of the reqd number is :" + (Math.Sqrt(num)));
        }
    }
}
