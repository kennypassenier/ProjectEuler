using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem21
    {
        private int _limit = 10000;
        public Problem21()
        {
            List<int> amicableNumbers = new List<int>();
            for (int counter = 1; counter < _limit; counter++)
            {
                int result = MathHelper.SumOfProperDivisors(counter);
                int resultSum = MathHelper.SumOfProperDivisors(result);
                if(resultSum == counter)
                {
                    // Als het resultaat hetzelfde is als het grondgetal, spreken we niet over een amicable number.
                    if (result != counter)
                        amicableNumbers.Add(counter);
                }
            }
            Console.WriteLine(amicableNumbers.Sum());           
        }
    }
}
