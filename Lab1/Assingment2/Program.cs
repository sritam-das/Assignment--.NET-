using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment2
{
    struct Members
    {
        private string FirstName;
        private string LastName;
        private string FullName;

        public void getValue(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
            FullName = fName +" "+ lName;
        }

        public void display()

        {
            Console.WriteLine("First Name = "+FirstName);
            Console.WriteLine("Last Name = "+LastName);
            Console.WriteLine("Full Name =" + FullName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Assignment 2: Structures
            1) Create a structure with three members:
            FirstName, LastName and FullName
            Accept the values for FirstName and LastName from user. Write a method to concatenate the 
            value of FirstName and LastName, assign it to FullName and display it
             */
            Members m = new Members();
            m.getValue("lokesh", "Bramhe");
            m.display();
            Console.ReadLine();
        }
    }
}
