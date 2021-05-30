using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment
{
    public delegate bool Loan(LoanApplication lps);
    public class LoanApplication
    {
        public int LoanApplicationID { get; set; }
        public string ApplicantName { get; set; }
        public int LoanAmount { get; set; }
        public bool isLoanApproved { get; set; }

        public  bool setLoanStatus(LoanApplication lpa)
        {
            if(lpa.LoanAmount > 35000)
            {
                isLoanApproved = true;
                return isLoanApproved;
            }
            else
            {
                return false;
            }
            
        }

        public static void LoanAmt(List<LoanApplication> loanapplicant, Loan lps)
        {
            foreach (LoanApplication lpa in loanapplicant)
            {
                if (lps(lpa))
                {
                    Console.WriteLine("Loan for {0} Approved.",lpa.ApplicantName);
                }
            }
        }
    }
}
