using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student
    {
        int RollNo;
        string StudentName, Address, Course;
        int CourseFees;
        double ScholarshipAmount;

       public Student()
        {
            RollNo = 0;
            StudentName = "null";
            Address = "null";
            Course = "null";
            CourseFees = 0;
            ScholarshipAmount = 0;
        }

       public  Student(int rno,string sname, string add, string cou, int cFees, double schamo)
        {
            RollNo = rno;
            StudentName = sname;
            Address = add;
            Course = cou;
            CourseFees = cFees;
            ScholarshipAmount = schamo;
        }
       public virtual void setData(int rno, string sname, string add, string cou, int cFees, double schamo)
        {
            RollNo = rno;
            StudentName = sname;
            Address = add;
            Course = cou;
            CourseFees = cFees;
            ScholarshipAmount = schamo;
        }
        public virtual void displayStudent()
        {
            Console.WriteLine();
            Console.WriteLine("RollNo = "+RollNo+"  Student Name = "+ StudentName+ " Address = "+ Address);
            Console.WriteLine("Course = "+ Course+ " Course Fees = "+CourseFees+ " Scholarship Amount = "+ ScholarshipAmount);
        }
        public void shh()
        {
            Console.WriteLine("okk");
        }
    }
}
