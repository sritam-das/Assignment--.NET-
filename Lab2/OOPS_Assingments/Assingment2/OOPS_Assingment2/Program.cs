using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project;
namespace OOPS_Assingment2
{
    class Program
    {
        /*Cybage wants to maintain information about the marks scored by the participant in various 
        training modules. Write a program to store the details of the marks scored in various modules
        */
        static void Main(string[] args)
        {
            Trainee t1 = new Trainee();
            t1.SetData(1,"Lokesh",50,50,50);
            t1.MarksScoredByStudent();
            t1.PercentageOfStudent();
            Console.ReadLine();
        }
    }
}
