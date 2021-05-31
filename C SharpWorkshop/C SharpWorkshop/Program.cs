using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle obj = new Triangle(5, 10);
            obj.DisplayArea();
            obj.displayDimensions();
            obj.DisplayPerimeter();

            Console.WriteLine();
            Console.WriteLine();

            Rectangle recObj = new Rectangle(10, 15);
            recObj.DisplayArea();
            recObj.displayDimensions();
            recObj.DisplayPerimeter();

            Console.WriteLine();
            Console.WriteLine();

            RightAngledTriangle rightObj = new RightAngledTriangle(4, 5, 10);
            rightObj.DisplayArea();
            rightObj.displayDimensions();
            rightObj.DisplayPerimeter();

            List<Shapes> listObj = new List<Shapes>();
            listObj.Add(recObj);
            listObj.Add(obj);
            listObj.Add(rightObj);

            Console.WriteLine("********************************");
            foreach(Shapes element in listObj)
            {
                 element.DisplayArea();
                 element.DisplayPerimeter();
                 element.displayDimensions();
                 element.DisplayType();
            }

            Stack stackObj = new Stack();
            stackObj.Push(obj);
            stackObj.Push(recObj);
            stackObj.Push(rightObj);
            Console.WriteLine();
            Console.WriteLine("*************************************");
            Console.WriteLine("Removing from the stack");
            while(stackObj.Count >0)
            {
                Console.WriteLine("Removed:" + stackObj.Pop());
            }

        }
    }
}
