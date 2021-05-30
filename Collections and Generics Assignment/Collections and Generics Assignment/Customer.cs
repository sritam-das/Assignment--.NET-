using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_and_Generics_Assignment
{
    public class Customer
    {
        public int customerID { get; set; }
        public string customerName { get; set; }
        public int contact { get; set; }
        public string email { get; set; }

        public Customer(int id)
        {
            customerID = id;
        }

        public Customer(int id, string name, int con, string mail)
        {
            customerID = id;
            customerName = name;
            contact = con;
            email = mail;
        }

        public override string ToString()
        {
            return "Customer Details:" + customerID + "\t" + customerName + "\t" + contact + "\t" + email;
        }
    }
}
