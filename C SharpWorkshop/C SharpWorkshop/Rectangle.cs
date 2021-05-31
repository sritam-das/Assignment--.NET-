using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpWorkshop
{
    public class Rectangle : Shapes
    {

        public int length { get; set; }
        public int breadth { get; set; }

        public Rectangle()
        {
            length = 0;
            breadth = 0;
        }

        public Rectangle(int l, int b)
        {
            length = l;
            breadth = b;
        }
        public override void DisplayArea()
        {
            Console.WriteLine("The reqd area of the triangle  is:" +(length*breadth));
        }

        public override void displayDimensions()
        {
            Console.WriteLine("The dimensions are: length :{0} , breadth:{1}", length, breadth);
        }

        public override void DisplayPerimeter()
        {
            Console.WriteLine("The reqd perimeter is:" + 0.5*(length+breadth));
        }

        public override void DisplayType()
        {

            Console.WriteLine(typeof(Rectangle));
        }
        public override string ToString()
        {
            return "Area of rectangle:" +  length * breadth;
        } 
    }
}
