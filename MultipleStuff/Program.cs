using System;
using System.Runtime.InteropServices;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperList sl = new SuperList(){2,3,4,5,6,7,8};

            //Parâmetros out
            sl.GetMinMax1(out double Min, out double Max);
            Console.WriteLine($"Min: {Min}; Max: {Max}");

            //Com classe/struct específica
            SuperList.GetMinMaxStruct minMax2 = sl.GetMinMax2();
            Console.WriteLine($"Min: {minMax2.Min}; Max: {minMax2.Max}");

            //Com tuplos de referência
            (double min3, double max3) minMax3 = sl.GetMinMax3();
            Console.WriteLine($"Min: {minMax3.min3}; Max: {minMax3.max3}");

            //Com tuplos de valor e nomes definidos por nós
            (double min4, double max4) minMax4 = sl.GetMinMax4();
            Console.WriteLine($"Min: {minMax4.min4}; Max: {minMax4.max4}");
        }
    }
}
