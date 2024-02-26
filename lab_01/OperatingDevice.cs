using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;

namespace queuing_system
{
    public class Operator
    {
        private readonly double _mean;
        private readonly double _standardDeviation;
        public bool busy = false;

        public Operator(double mean, double standardDeviation)
        {
            this._mean = mean;
            this._standardDeviation = standardDeviation;
        }

        public double GetTime()
        {
            return Normal.Sample(this._mean, this._standardDeviation);
        }
    }
}
