using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler
{
    public class Problem20
    {
        private BigInteger _numberValue;

        public BigInteger Number
        {
            get { return _numberValue; }
            set { _numberValue = value; }
        }
        public Problem20()
        {
            Number = MathHelper.BigIntFactorial(100);
            Console.WriteLine($"Number: {Number}");
            Console.WriteLine(SumOfDigits(Number.ToString()));
        }
        public int SumOfDigits(string nummerString)
        {
            int sum = 0;
            foreach (var character in nummerString.ToCharArray())
            {
                sum += Convert.ToInt32(character);
            }
            return sum;
        }



    }
}
