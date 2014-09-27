using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_apps
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle aCircle = new Circle();
            aCircle.radias = 269;
           Console.WriteLine("area is :"+ aCircle.GetArea());
           Console.WriteLine("Perimeter is :" + aCircle.GetPerimeter());
           Console.WriteLine("Diameter is :" + aCircle.GetDiameter());
             Console.ReadLine();
        }
    }
}
