using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal struct point
    {
        //attribute
        public int x; 
        public int y;

        //----------------------
        //constructor: special function
        //has no return type
        //always same name of class or struct

        public point()
        {
            x = 0; 
            y = 0;
        }
        public point(int _x, int _y)
        {
            x=_x; 
            y = _y;

        }

        //method
        public override string ToString()
        {
            return $"X:{x}, Y:{y}"; 
        }
    }
}
