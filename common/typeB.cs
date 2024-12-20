using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    internal class typeB
    {
        public typeB()
        {  //constructor
            typeA obj = new typeA();
            // obj.x; // invaild
            obj.y = 1; //valid
            obj.z = 2; //valid
        }
    }
}
