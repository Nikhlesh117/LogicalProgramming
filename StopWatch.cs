using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace LogicalProgramming
{
    public class StopWatch
    {
        public static void Simulation()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Starting");
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed : " + stopwatch.Elapsed);
        }
    }
}