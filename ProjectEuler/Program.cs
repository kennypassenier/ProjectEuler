using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Problem1();
            //new Problem2();
            Console.WriteLine(MathHelper.IsPalindrome(515));
            List<int> test = MathHelper.Factors(38);
            foreach (var item in test)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
