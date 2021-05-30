using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
namespace Assingment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student s = new ForeignStudent();
            //s = new DomesticStudent();
            //s.displayStudent();
            //s.setData(1, "lokesh", "okk", "okk", 5000, 0);
            //s.displayStudent();
            //Student s1 = new Student();

            //ForeignStudent f = new ForeignStudent();
            //f = new DomesticStudent();
            //f.shh();
            //ForeignStudent f1 = (ForeignStudent)new Student();
            Student s = new ForeignStudent();
            s.displayStudent();

            Console.ReadLine();

        }
    }
}
