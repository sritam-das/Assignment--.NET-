using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
namespace Assingment1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            int rolNo;
            Console.WriteLine("Enter the Roll no");
            rolNo = Int32.Parse((Console.ReadLine()));
            string sName;
            Console.WriteLine( "Enter the Student Name");
            sName = Console.ReadLine();
            string addre;
            Console.WriteLine("Enter the Student addre");
            addre = Console.ReadLine();
            string cName;
            Console.WriteLine("Enter the Course Name");
            cName = Console.ReadLine();
            int cFee;
            Console.WriteLine("Enter the Course Fees");
            cFee = Int32.Parse((Console.ReadLine()));
            int sch;
            Console.WriteLine("Enter the SchollerSchipe");
            sch = Int32.Parse((Console.ReadLine()));
            s1.setData(rolNo, sName, addre, cName, cFee, sch);
            s1.displayStudent();
            Console.ReadLine();
        }
    }
}
