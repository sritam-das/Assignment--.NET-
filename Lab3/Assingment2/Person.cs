using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment2
{
    class Person
    {
        static void Main(string[] args)
        {
            EmailApplication EA = new EmailApplication();
            ISpellChecker i = new EmailApplication();
            i.PerformSpellCheck();
            ISpellCheckerSpanish iss= new EmailApplication();
            iss.PerformSpellCheck();
            Console.ReadLine();
            
        }
    }
}
