using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;


namespace queuing_system
{
    public class Generator
    {
        private readonly double _mean;
        private readonly double _standardDeviation;

        public Generator(double mean, double standardDeviation)
        {
            this._mean = mean;
            this._standardDeviation = standardDeviation;
        }

        public double GetTime()
        {
            return ContinuousUniform.Sample(_mean - _standardDeviation, 
                                            _mean + _standardDeviation);
        }
    }
}
