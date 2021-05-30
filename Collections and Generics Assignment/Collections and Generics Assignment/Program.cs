using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections_and_Generics_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();
           
            while(true)
            {
                Console.WriteLine("********************MENU***********************");
                Console.WriteLine("1. Add Customer\n2. Search Customer\n3. Delete Customer");
                Console.WriteLine("Enter your choice:");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter credentials: Id, Name, Contact, Email");

                        obj.Add( new Customer(int.Parse(Console.ReadLine()), Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine()));
                        foreach (object element in obj)
                        {
                            Console.WriteLine(obj.IndexOf(element));
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter customer Id:");
                        int value = int.Parse(Console.ReadLine());
                       for(int i=0; i<obj.Count;i++)
                        {
                            if(obj[i].Contains(obj.value))
                            {
                                obj.ToString();
                            }
                        }
                       
                      
                        
                        break;

                    case 3:
                        break;
                }
            }
        }
    }
}
