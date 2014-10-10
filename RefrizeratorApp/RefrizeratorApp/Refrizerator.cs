using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefrizeratorApp
{
    class Refrizerator
    {
        public double MaxWeight { set; get; }
        public double CurrentWeight { private set; get; }
        public double RemainingWeight { private set; get; }

        public Refrizerator(double maxWeight)
        {
            MaxWeight = maxWeight;
        }

        public void AddItems(int NoOfItems, double weightPerUnit)
        {
            double weightToBeAdded = NoOfItems*weightPerUnit;
            if (CurrentWeight + weightToBeAdded <= MaxWeight)
            {
                CurrentWeight += weightToBeAdded;
                RemainingWeight = MaxWeight - CurrentWeight;
            }
            else
            {
                throw new Exception();
            }
        }

    }
}
