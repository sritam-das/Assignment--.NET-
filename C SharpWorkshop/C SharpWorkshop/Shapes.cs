using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpWorkshop
{
    public abstract class Shapes
    {
        public abstract void displayDimensions();

        public abstract void DisplayArea();

        public abstract void DisplayPerimeter();

        public virtual void DisplayType() { }

        
    }
}
