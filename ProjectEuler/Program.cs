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

            var persoon = new Persoon(new List<string> { "bart", "jan", "jos" });
            Console.WriteLine(persoon.ToString());


            //new Problem17();

            sw.Stop();
            Console.WriteLine(String.Format("Solution found in {0} milliseconds", sw.ElapsedMilliseconds));

        }
    }
}
