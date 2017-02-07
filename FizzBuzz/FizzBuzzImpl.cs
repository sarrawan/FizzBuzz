using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzImpl
    {
        public string Compute(int numToCountTo)
        {
            string result = "1";
            for (int index = 2; index <= numToCountTo; index++)
            {

                if (CheckDivisibleByBoth(index))
                {
                    result += ", Fizz Buzz";
                }
                else if (CheckDivisibleByThree(index))
                {
                    result += ", Fizz";
                }
                else if (CheckDivisibleByFive(index))
                {
                    result += ", Buzz";
                }
                else
                {
                    result += ", " + index;
                }
            }
            return result;
        }

        private static bool CheckDivisibleByBoth(int index)
        {
            return CheckDivisibleByFive(index) && CheckDivisibleByThree(index);
        }

        private static bool CheckDivisibleByFive(int index)
        {
            return index % 5 == 0;
        }

        private static bool CheckDivisibleByThree(int index)
        {
            return index % 3 == 0;
        }
    }
}
