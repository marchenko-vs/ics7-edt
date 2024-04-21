using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Operator
    {
        double mean;
        double standardDeviation;

        public bool busy = false;

        double mean1;
        double standardDeviation1;

        double mean2;
        double standardDeviation2;

        public Operator(double mean, double standardDeviation)
        {
            this.mean = mean;
            this.standardDeviation = standardDeviation;
        }

        public Operator(double mean1, double standardDeviation1, double mean2, double standardDeviation2)
        {
            this.mean1 = 1 / mean1;
            this.standardDeviation1 = standardDeviation1;

            this.mean2 = 1 / mean2;
            this.standardDeviation2 = standardDeviation2;
        }

        public double GetTime()
        {
            return Normal.Sample(mean, standardDeviation);
        }

        public double GetTime1()
        {
            return Normal.Sample(mean1, standardDeviation1);
        }

        public double GetTime2()
        {
            return Normal.Sample(mean2, standardDeviation2);
        }
    }
}
