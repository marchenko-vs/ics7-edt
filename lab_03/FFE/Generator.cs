using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;

namespace ConsoleApp1
{
    internal class Generator
    {
        double mean;
        double standardDeviation;

        public Generator(double mean, double standardDeviation)
        {

            this.mean = 1 / mean;
            this.standardDeviation = this.mean * standardDeviation / mean;
            //this.standardDeviation = standardDeviation;
        }

        public double GetTime()
        {
            return ContinuousUniform.Sample(mean - standardDeviation, mean + standardDeviation);
        }
    }
}
