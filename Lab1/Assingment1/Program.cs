using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment1
{
    class Program
    {

        #region Assingment1
        /*Assignment 1: Switch Case
        Accept the value from the user and check whether its 100 or 1000. Print the message 
        accordingly. If user enters any value other than 100 or 1000, print the error message. Use 
        switch case to solve this.*/
        #endregion

        
        static void Main(string[] args)
        {
            #region Solution
            Console.WriteLine("Enter the Number");
            Console.WriteLine(" 1 : For 100");
            Console.WriteLine(" 2 : For 1000");
            Console.WriteLine(" 3 : Exit");

            int num;
            num = Convert.ToInt32(Console.ReadLine());
            while(num != 3)
            {
               /* if (num == 1 || num == 2 || num == 3)
                {*/
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("You Enter 100");
                            break;
                        case 2:
                            Console.WriteLine("You Enter 1000");
                            break;
                        case 3:
                            Console.WriteLine("Exit");
                            break;
                        default:
                            Console.WriteLine("You Enter wrong value");
                            break;
                    }
               /* }
                else
                {
                    Console.WriteLine("You Enter Wrong Value");
                }*/
                num =Convert.ToInt32(Console.ReadLine());
            }
           // Console.WriteLine("hi");
            Console.ReadLine();
            #endregion
        }
    }
}
