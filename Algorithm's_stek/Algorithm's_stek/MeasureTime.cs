using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Algorithm_s_stek
{
    public class MeasureTime
    {
        double CountOfRepeat;

        public MeasureTime(double c)
        {
            CountOfRepeat = c;
        }

        public Dictionary<string, double> MethodTimeCounter(Dictionary<string, string> input, Action<string> algorithm)
        {
           
            var resultOfMeasure = new Dictionary<string, double>();

            foreach (var e in input.Keys)
            {
                Console.WriteLine("Checking file: " + e);
                var watch = new Stopwatch();
                watch.Start();
                for (int i = 0; i < CountOfRepeat; i++)
                {
                    algorithm(input[e]);
                }
                watch.Stop();
                var result = (double)watch.ElapsedMilliseconds /CountOfRepeat;
                resultOfMeasure.Add(e, result);

            }
            return resultOfMeasure;
        }
    }
}

