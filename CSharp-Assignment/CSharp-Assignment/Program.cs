using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment
{
    public delegate void mathDelegate(int num);
    class Program
    {
        public event Loan displayEvent;
        static void Main(string[] args)
        {
            #region Delegate
               Console.WriteLine("Hello User !!!!!");
               Console.WriteLine();
               Console.WriteLine("Enter the number you want to input :");
               int value = int.Parse(Console.ReadLine());

               while (true)
               {
                   Console.WriteLine("****************************************************");
                   Console.WriteLine("1. SQUARE \n2. SQUARE ROOT \n3. CUBE");
                   Console.WriteLine("Enter your choice :");
                   int choice = int.Parse(Console.ReadLine());

                   switch (choice)
                   {
                       case 1:
                           mathDelegate obj = new mathDelegate(DelegateAssignment.Square);
                           obj.Invoke(value);
                           break;

                       case 2:
                           mathDelegate obj1 = new mathDelegate(DelegateAssignment.SquareRoot);
                           obj1.Invoke(value);
                           break;

                       case 3:
                           mathDelegate obj3 = new mathDelegate(DelegateAssignment.Cube);
                           obj3.Invoke(value);
                           break;

                       case 10:
                           Console.WriteLine("your input in default case is : {0}", value);
                           return;
                   }
               }          
            #endregion

            #region Event
         /*   LoanApplication la1 = new LoanApplication()
            { 
                    LoanApplicationID=101,
                    ApplicantName="Sritam Das",
                    LoanAmount=55000
            };
            LoanApplication la2 = new LoanApplication()
            {
                LoanApplicationID = 102,
                ApplicantName = "Subhada Chaube",
                LoanAmount = 45000
            };
            LoanApplication la3 = new LoanApplication()
            {
                LoanApplicationID = 103,
                ApplicantName = "Vinay Talreja",
                LoanAmount = 15000
            };

            List<LoanApplication> loanapplicant = new List<LoanApplication>();
            loanapplicant.Add(la1);
            loanapplicant.Add(la2);
            loanapplicant.Add(la3);

            LoanApplication objs = new LoanApplication();

            Loan obj = new Loan(objs.setLoanStatus);
            LoanApplication.LoanAmt(loanapplicant, obj);
            Console.WriteLine();  */

            #endregion

        }
    }
}
