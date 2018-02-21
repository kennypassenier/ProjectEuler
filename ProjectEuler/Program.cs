using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();


            for (int i = 0; i < 100; i++)
            {
                if (MathHelper.IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }

            sw.Stop();
            Console.WriteLine(String.Format("Solution found in {0} milliseconds", sw.ElapsedMilliseconds));
        }
    }
}
