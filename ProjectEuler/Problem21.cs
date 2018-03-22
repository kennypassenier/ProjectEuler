using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem21
    {
        private int limit = 10000;
        public Problem21()
        {
            List<int> AmicableNumbers = new List<int>();
            for (int counter = 1; counter < limit; counter++)
            {
                int result = MathHelper.SumOfProperDivisors(counter);
                int resultSum = MathHelper.SumOfProperDivisors(result);
                if(resultSum == counter)
                {
                    // Als het resultaat hetzelfde is als het grondgetal, spreken we niet over een amicable number.
                    if (result != counter)
                        AmicableNumbers.Add(counter);
                }
            }
            Console.WriteLine(AmicableNumbers.Sum());           
        }
    }
}
