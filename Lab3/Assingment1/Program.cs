using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MaharashtraGovernment mh = new MaharashtraGovernment();
            int d = mh.Price=2000;
            mh.CalculateTax("MaharashtraGovernment","Gold", d);
            APGovernment ap = new APGovernment();
            int dd=ap.Price = 1000;
            
             ap.CalculateTax("aa","aa",dd);
            Console.ReadLine();
        }
    }
}
