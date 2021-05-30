using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment3._2
{
    class Program
    {
        /*
         * Step 2: Write a code to create a multidimensional array of 3 rows and 4 columns. Write a code 
            to accept the values from the user and display the elements of the array */
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4];
            /*{
                {1,2,3,4},{5,6,7,8},{9,10,11,12}
            };*/
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Enter the value at position arr[" + i + "][" + j + "]=");
                    arr[i, j] =Int32.Parse(Console.ReadLine());
                    //Console.WriteLine(arr[i, j]);
                }
            }
            Console.WriteLine("Array is ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
