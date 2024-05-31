using System;
using System.Collections.Generic;
using System.Linq;

namespace MultipleStuff
{
    class SuperList : List<double>  
    {
        public void GetMinMax1(out double min, out double max)
        {
            min = this.Min();
            max = this.Max();
        }

        public struct GetMinMaxStruct
        {
            public double Min;
            public double Max;
        }
        public GetMinMaxStruct GetMinMax2()
        {
            return new GetMinMaxStruct
            { 
                Min = this.Min(), 
                Max = this.Max() 
            };
        }

        public (double min, double max) GetMinMax3()
        {
            return (this.Min(), this.Max());
        }

        public (double minimum, double maximum) GetMinMax4()
        {
            return (this.Min(), this.Max());
        }
    }
}
