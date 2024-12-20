using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal struct Point
    {
        public double X1;
        public double Y1;
        public double X2;
        public double Y2;
        public double res;

        public Point(double _x1, double _y1, double _x2, double _y2)
        {
            X1 = _x1;
            Y1 = _y1;
            X2 = _x2;
            Y2 = _y2;

            res = Math.Sqrt(Math.Pow((X2 - X1), 2)
                         + Math.Pow((Y2 - Y1), 2));

            //res = Math.Sqrt(Math.Pow((_x2 - _x1), 2)
            //            + Math.Pow((_y2 - _y1), 2));
        }
        public override string ToString()
        {
            return $"result is : {res = Math.Sqrt(Math.Pow((X2 - X1), 2)
                         + Math.Pow((Y2 - Y1), 2))}";
        }
    }
}
