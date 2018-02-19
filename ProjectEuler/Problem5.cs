using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem5
    {
        public Problem5()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            long limit = 30;
            long number = 1;
            while(MathHelper.IsEvenlyDivisible(number, limit) == false)
            {
                number++;
            }
            Console.WriteLine(number);
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }
    }
}
