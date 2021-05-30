using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment1
{
   abstract class CentralGovernment
    {
        public int Price { get; set; }
        public abstract int CalculateTax(string stateName, string commodityName,  int taxRate);
    }
}
