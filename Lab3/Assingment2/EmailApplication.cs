using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment2
{
    public class EmailApplication : ISpellChecker, ISpellCheckerSpanish
    {
        string ISpellCheckerSpanish.PerformSpellCheck()
        {
            Console.WriteLine("Performed spell check using Spanish");
            return "";
        }


        string ISpellChecker.PerformSpellCheck()
        {
            Console.WriteLine("Performed spell check using English");
            return "";
        }
    }
}
