using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace culculete_result_apps
{
    class Culculat
    {
        private double physics;
        private double chemistry;
        private Double math;
        private double avarage;

        public double Physics
        {
            set
            {
                if (100 >= value)  {
                physics = value;
                }
            }
        }
        public double Chemistry
        {
            set
            {
                if (100 >= value)
                {
                    chemistry = value;
                }
            }
        }
        public double Math
        {
            set
            {
                if (100 >= value)
                {
                    math = value;
                }
            }
        }

        public double Avarage
        {
            get { return avarage; }
        }

        public Culculat()
          {
           // avarage = physics + chemistry + math/3;
        }

        public double CulculatAvarage()
        {
           return (physics + chemistry + math)/3;
        }

        public string Grade()
        {
            string grate;
            if (avarage >= 80)
            {
                grate = "A+";
            }
            else if(avarage>=70)
            {
                grate = "B+";
            }
            else if(avarage>=60)
            {
                grate = "C+";
            }
            else if(avarage>=50)
            {
                grate = "D+";
            }
            else
            {
                grate = "F";
            }
            return grate;
        }
    
    }
}
