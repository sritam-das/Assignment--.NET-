using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpWorkshop
{
    public class Triangle : Shapes
    {
        public int length { get; set; }
        public int height { get; set; }

        public Triangle()
        {
            length = 0;
            height = 0;
        }

        public Triangle(int l, int h)
        {
            length = l;
            height = h;
        }
        public override void DisplayArea()
        {
            Console.WriteLine("The reqd area of the triangle  is:"+ 0.5*length*height);
        }

        public override void displayDimensions()
        {
            Console.WriteLine("The dimensions are: length :{0} , height:{1}", length, height);
        }

        public override void DisplayPerimeter()
        {
            Console.WriteLine("The reqd perimeter is:" + (length+height));
        }

        public override void DisplayType()
        {

            Console.WriteLine(typeof(Triangle));
        }
        public override string ToString()
        {
            return "Area of triangle:" + 0.5 * length * height;
        }
    }
}
