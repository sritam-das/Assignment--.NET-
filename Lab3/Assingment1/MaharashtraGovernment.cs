using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment1
{
    class MaharashtraGovernment : CentralGovernment
    {
        /* int Gold = 3;
         int car =7;
         int Chocklate =9;
         int v;
        */
        // MaharashtraGovernment m = new MaharashtraGovernment();
        double price;
        public override int CalculateTax(string stateName, string commodityName,  int taxRate)
        {
            price = ((taxRate * 0.04) + (taxRate * 0.06) + (taxRate * 0.10));
            Console.WriteLine("state: " + stateName + " Comodity name : " + commodityName + " Price " + price);
            // throw new NotImplementedException();
            return (1);
        }
    }
}
