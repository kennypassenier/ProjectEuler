using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem10
    {
        public Problem10()
        {
            int limit = 10;
            List<int> primes = new List<int>();
            long sum = 0;
            for (int number = 1; number < limit; number++)
            {
                
                if (MathHelper.IsPrime(number))
                {
                    Console.WriteLine(number);
                    sum += number;
                }                
            }
            Console.WriteLine(sum);
        }
    }
}
