using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_apps
{
    class Circle
    {
       public double radias;
        public double GetArea()
        {
            return 2 * radias;
        }

    public double GetPerimeter()
        {
            return 2 * Math.PI * radias;
        }

    public double GetDiameter()
        {
            return Math.PI * radias * radias;
        }

   
    }
}
