using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem23
    {
        private const int Limit = 28123;
        private List<int> _abundantNumbersValue;

        public List<int> AbundantNumbers
        {
            get { return _abundantNumbersValue; }
            set { _abundantNumbersValue = value; }
        }
        public Problem23()
        {
            AbundantNumbers = new List<int>();
            // Er werkt iets niet bij nummers kleiner dan tien.
            for (int number = 10; number <= Limit; number++)
            {
                if(MathHelper.SumOfProperDivisors(number) > number)
                {
                    AbundantNumbers.Add(number);
                }
            }
            List<int> posIntegers = new List<int>();
            for (int number = 1; number < Limit; number++)
            {
                foreach (var item in AbundantNumbers)
                {
                    if(AbundantNumbers.Contains(number - item) == false)
                    {
                        Console.WriteLine($"Number found: {number}\nSubtotal: {posIntegers.Distinct().Sum()}");
                        posIntegers.Add(number);
                        break;
                    }
                }
            }
            Console.WriteLine(posIntegers.Distinct().Sum());
        }
    }
}
