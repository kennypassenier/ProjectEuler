using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem2
    {
        // This is the limit as stated by project euler. 
        private const int limit = 4000000;
        private List<int> fibListValue;

        public List<int> FibList
        {
            get { return fibListValue; }
            set { fibListValue = value; }
        }

        public Problem2()
        {
            // The first two numbers in the sequence are given, the rest can be based upon those numbers. 
            FibList = new List<int>();
            FibList.Add(1);
            FibList.Add(2);
            CompleteList();
            Console.WriteLine(SumOfEvenValuedTerms());
        }

        public int NextFib()
        {
            return FibList[FibList.Count - 2] + FibList[FibList.Count - 1];
        }

        public void CompleteList()
        {
            while(NextFib() < limit)
            {
                FibList.Add(NextFib());
            }
        }

        private int SumOfEvenValuedTerms()
        {
            int sum = 0;
            foreach (var number in FibList)
            {
                if(number % 2 == 0)
                    sum += number;
            }
            return sum;
        }



    }
}
