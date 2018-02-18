using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem1
    {
        public Problem1()
        {
            int limit = 1000;
            int sum = 0;
            for (int number = 0; number < limit; number++)
            {
                if(number % 3 == 0 || number % 5 == 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine("The answer is: {0}", sum);
        }
    }
}
