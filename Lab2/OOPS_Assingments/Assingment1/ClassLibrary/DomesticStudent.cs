using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   public class DomesticStudent:Student
    {
        DomesticStudent ds = new DomesticStudent();
        public override void displayStudent()
        {
            base.displayStudent();
        }
        public override void setData(int rno, string sname, string add, string cou, int cFees, double schamo)
        {
            base.setData(rno, sname, add, cou, cFees, (0.1*cFees));
        }
    }
}
