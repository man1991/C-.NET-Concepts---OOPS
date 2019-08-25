using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Fundamentals
{
    class PerformanceOf_DataType
    {
        static void Main(string[] args)
        {
            Stopwatch o = new Stopwatch();
            o.Start();

            for(int i=0; i < 10000; i++)
            {
                short x = 10;
            }
            o.Stop();
            Console.WriteLine(o.ElapsedTicks.ToString());

            o.Start();
            for (int i = 0; i < 10000; i++)
            {
                decimal x = 10;
            }
            o.Stop();
            Console.WriteLine(o.ElapsedTicks.ToString());
            Console.ReadLine();
        }
    }
}
