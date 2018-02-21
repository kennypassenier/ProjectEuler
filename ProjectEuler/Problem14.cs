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

            
            foreach (var item in CollatzSequence(28))
            {
                Console.WriteLine(item);
            }
            //int limit = 1000000;
            //int longestChain = 1;
            //int longestChainLength = 1;
            //for (int number = 1; number < limit; number++)
            //{
            //    List<int> sequence = CollatzSequence(number);
            //    if (sequence.Count > longestChainLength)
            //    {
            //        longestChainLength = sequence.Count;
            //        longestChain = number;
            //    }
            //}
            //Console.WriteLine(String.Format("The longest chain is {0} long and comes from the number: {1}", longestChainLength, longestChain));
        }

        private int CollatzNext(int number)
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

        private List<int> CollatzSequence(int number)
        {
            List<int> SequenceList = new List<int>() { number };
            while (SequenceList[SequenceList.Count - 1] != 1)
            {
                SequenceList.Add(CollatzNext(SequenceList[SequenceList.Count - 1]));
            }
            return SequenceList;
            
        }        
    }
}
