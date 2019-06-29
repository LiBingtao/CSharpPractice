using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oven
{
    public class Oven
    {
        private int temprature = 37;
        private int threshold;
        public Oven(int threshold)
        {
            this.threshold = threshold;
            OnTempratureToThreshold += BlowUp;
        }
        
        public void Run()
        {
            while (temprature < threshold)
            {
                System.Threading.Thread.Sleep(1000);
                temprature += 1;
            }
            OnTempratureToThreshold();
        }

        private event ThresholdHandler OnTempratureToThreshold;
        private delegate void ThresholdHandler();


        private void BlowUp()
        {
            Console.WriteLine("Boom sha ka la ka");
        }
    }
}
