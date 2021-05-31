using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    [Serializable]
    public class Person
    {
        public int Age { get; set; }
        public string name { get; set; }
        public DateTime DOB {get; set;}
        public string AdditionalInfo { get; set; }

        public override string ToString()
        {
            return "Details:" + Age + "," + name + "," + DOB + "," + AdditionalInfo;
        }

    }
}
