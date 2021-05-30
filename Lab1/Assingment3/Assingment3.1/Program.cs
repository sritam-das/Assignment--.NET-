using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment3._1
{
    class Program
    {
        /*
         Step 1: Define a single dimensional array to hold states. Print elements of this array using 
         foreach loop.
        */
        static void Main(string[] args)
        {
            int[] num = new int[5] { 1, 2, 3, 4, 5 };
            
            foreach (var i in num)
            {
                Console.WriteLine(i);
                
            }
            Console.ReadLine();
        }
    }
}
