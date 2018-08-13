using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem14
    {
        public Problem14()
        {



            int limit = 1000000;
            long longestChain = 1;
            long longestChainLength = 1;
            for (long number = 100000; number < limit; number++)
            {
                List<long> sequence = CollatzSequence(number);
                if (sequence.Count > longestChainLength)
                {
                    longestChainLength = sequence.Count;
                    longestChain = number;
                }
            }
            Console.WriteLine(String.Format("The longest chain is {0} long and comes from the number: {1}", longestChainLength, longestChain));
        }

        private long CollatzNext(long number)
        {
            if(number % 2 == 0)
            {
                return number / 2;
            }
            else
            {
                return 3 * number + 1;
            }
        }

        private List<long> CollatzSequence(long number)
        {
            List<long> sequenceList = new List<long>() { number };
            while (sequenceList[sequenceList.Count - 1] != 1)
            {
                sequenceList.Add(CollatzNext(sequenceList[sequenceList.Count - 1]));
            }
            return sequenceList;
            
        }        
    }
}
