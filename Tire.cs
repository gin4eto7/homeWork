using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Tire
    {
        public Tire(List<double> tiresPressure, List<int> tiresAge)
        {
            TiresPressure = tiresPressure;
            TiresAge = tiresAge;
        }

        public List<double> TiresPressure { get; set; }

        public List<int> TiresAge { get; set; }

    }
}
