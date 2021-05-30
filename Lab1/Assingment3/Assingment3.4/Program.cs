using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment3._4
{

    /*
     * 4: Create a console application and add the Employee class to it. The Employee class 
should look as follows:
public class Employee
{
 public int EmployeeID {get;set;}
 public string EmployeeName {get;set;}
 public int Salary {get;set;}
}
Create an array of 3 employees and accept the values for EmployeID, EmployeeName and 
Salary as follows:
Employee[] employees=new Employee[3];
for(int index=0;index<employees.Length;index++)
{
 Console.Write(“Enter Employee ID:”);
 employees[index]. EmployeeID = Convert.ToInt32 (Console.ReadLine());
 Console.Write(“Enter Employee Name:”);
 employees[index]. EmployeeName = Console.ReadLine();
 Console.Write(“Enter Salary:”);
 employees[index]. Salary = Convert.ToInt32 (Console.ReadLine()); 
}
Does this code throw any exception? If yes, find out the reason for the exception and fix that 
exception
     * */
    public class Employee
    {
        int EmployeID;
        string EmployeeName;
        double Salary;

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            for (int index = 0; index < employees.Length; index++)
            {
                Console.Write("Enter Employee ID : ");
                
                employees[index].EmployeeID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Employee Name : ");
                employees[index].EmployeeName = Console.ReadLine();
                Console.Write("Enter Salary : ");
                employees[index].Salary = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
