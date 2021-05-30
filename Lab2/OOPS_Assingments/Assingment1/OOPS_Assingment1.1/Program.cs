using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
namespace OOPS_Assingment1._1
{
    class Program
    {
        /*1) Cybage University wants to maintain information of their students. Create a class library 
project and add a Student class to it.
Student class should have following fields:
RollNo, StudentName, Address, Course, CourseFees, ScholarshipAmount
Write methods in Student class to set the values of these fields and retrieve the scholarship 
amount.*/
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.setData(1, "lokesh", "nagpur", "DotNet", 50000, 500);
            s1.displayStudent();
            Console.ReadLine();
        }
    }
}
