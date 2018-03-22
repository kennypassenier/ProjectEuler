using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem23
    {
        private const int limit = 28123;
        private List<int> abundantNumbersValue;

        public List<int> AbundantNumbers
        {
            get { return abundantNumbersValue; }
            set { abundantNumbersValue = value; }
        }
        public Problem23()
        {
            AbundantNumbers = new List<int>();
            // Er werkt iets niet bij nummers kleiner dan tien.
            for (int number = 10; number <= limit; number++)
            {
                if(MathHelper.SumOfProperDivisors(number) > number)
                {
                    AbundantNumbers.Add(number);
                }
            }
            List<int> PosIntegers = new List<int>();
            for (int number = 1; number < limit; number++)
            {
                Console.Clear();
                Console.WriteLine(number);
                foreach (var item in AbundantNumbers)
                {
                    if(AbundantNumbers.Contains(number - item) == false)
                    {
                        PosIntegers.Add(number);
                    }
                }
            }
            Console.WriteLine(PosIntegers.Sum());
        }
    }
}
