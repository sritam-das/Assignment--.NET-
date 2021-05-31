using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpWorkshop
{
    public class RightAngledTriangle:Triangle
    {
        public int hypotenuse;

        public RightAngledTriangle()
        {
            length = 0;
            height = 0;
            hypotenuse = 0;
        }

        public RightAngledTriangle(int l, int h,int hypo)
        {
            length = l;
            height = h;
            hypotenuse = hypo;
        }

        public override void DisplayArea()
        {
            Console.WriteLine("The reqd area is:" + 0.5*(length*height));
        }

        public override void displayDimensions()
        {
            Console.WriteLine("The dimensions are: length :{0} , height:{1} , hypotenuse:{2}", length, height, hypotenuse);
        }

        public override void DisplayPerimeter()
        {
            Console.WriteLine("The reqd perimeter is:" + (length + height+ hypotenuse));
        }

        public override void DisplayType()
        {

            Console.WriteLine(typeof(RightAngledTriangle));
        }
        public override string ToString()
        {
            return "Area of Right triangle:" + 0.5 * length * height;
        }
    }
}
