using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    class Culculat
    {
        private string name;
        private string reg;
        private  List<double> speedList=new List<double>();   
        public string Name
        {
         
            set { name = value; }
        }
        public string Reg
        {
        
            set {reg = value; }
        }

        public double Speed {
            set; get;
        }

        private string names;
        public Culculat()
        {
            names += name + reg;
        }

        public string GetName()
        {
            return name + reg;
        }

        public double SpeedClculate()
        {
            double sum = 0;
            foreach (var d in speedList)
            {
             
                sum += d;
            }
            double count = speedList.Count;
            return sum/count;

        }
        double max = 0;
        public double MaxCalculator()
        {

            double min = 0;
            if (Speed > max)
            {
                max = Speed;
                if (max <= min)
                {
                    min = Speed;
                }
            }
            else
            {
                min = Speed;
            }
            return max;
        }

        public double MinCalculator()
        {
            //double min = 0;
            //if (Speed > max)
            //{
            //    max = Speed;
            //    if (max <= min)
            //    {
            //        min = Speed;
            //    }
            //}
            //else
            //{
            //    min = Speed;
            //}
            return 0;
        }
    }
}
