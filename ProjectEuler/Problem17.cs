using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem17
    {        
        private Dictionary<int, string> oneToNineteenValue;

        public Dictionary<int, string> OneToNineteen
        {
            get { return oneToNineteenValue; }
            set { oneToNineteenValue = value; }
        }
        private Dictionary<int, string> tensValue;

        public Dictionary<int, string> Tens
        {
            get { return tensValue; }
            set { tensValue = value; }
        }
        private Dictionary<int, string> hundredsValue;

        public Dictionary<int, string> Hundreds
        {
            get { return hundredsValue; }
            set { hundredsValue = value; }
        }




        public Problem17()
        {
            OneToNineteen.Add(1, "one");
            OneToNineteen.Add(2, "two");
            OneToNineteen.Add(3, "three");
            OneToNineteen.Add(4, "four");
            OneToNineteen.Add(5, "five");
            OneToNineteen.Add(6, "six");
            OneToNineteen.Add(7, "zeven");
            OneToNineteen.Add(8, "eight");
            OneToNineteen.Add(9, "nine");
            OneToNineteen.Add(10, "ten");
            OneToNineteen.Add(11, "eleven");
            OneToNineteen.Add(12, "twelve");
            OneToNineteen.Add(13, "thirteen");
            OneToNineteen.Add(14, "fourteen");
            OneToNineteen.Add(15, "fifteen");
            OneToNineteen.Add(16, "sixteen");
            OneToNineteen.Add(17, "seventeen");
            OneToNineteen.Add(18, "eightteen");
            OneToNineteen.Add(19, "nineteen");
            Tens.Add(1, "ten");
            Tens.Add(2, "twenty");
            Tens.Add(3, "thirty");
            Tens.Add(4, "fourty");
            Tens.Add(5, "fifty");
            Tens.Add(6, "sixty");
            Tens.Add(7, "seventy");
            Tens.Add(8, "eighty");
            Tens.Add(9, "ninety");
            Hundreds.Add(1, "onehundred");
            Hundreds.Add(2, "twohundred");
            Hundreds.Add(3, "threehundred");
            Hundreds.Add(4, "fourhundred");
            Hundreds.Add(5, "fivehundred");
            Hundreds.Add(6, "sixhundred");
            Hundreds.Add(7, "zevenhundred");
            Hundreds.Add(8, "eighthundred");
            Hundreds.Add(9, "ninehundred");
        }

        public string WriteNumber(int number)
        {
            int numberLength = number.ToString().Length;
            if ( numberLength == 4)
            {
                return "onethousand";
            }
            else if (numberLength == 3)
            {
                int thirdDigit = number % 10;
                number /= 10;
                int secondDigit = number % 10;
                number /= 10;
                int firstDigit = number;
                // If the last two digits are < 20
                if (OneToNineteen.ContainsKey(number % 100))
                {
                    return String.Format($"{Hundreds[firstDigit]}{OneToNineteen[number % 100]}");
                }
                // If there are no zeroes in the number
                if (number.ToString().Contains("0") == false)
                {
                    return String.Format($"{Hundreds[firstDigit]}and{Tens[secondDigit]}{OneToNineteen[thirdDigit]}");
                }
                if (secondDigit == 0 && thirdDigit == 0)
                {
                    return String.Format($"{Hundreds[firstDigit]}");
                }
                else if (secondDigit == 0)
                {
                    return String.Format($"{Hundreds[firstDigit]}and{OneToNineteen[thirdDigit]}");
                }
                // Verder kopiëren van github
            }

        }
    }
}
