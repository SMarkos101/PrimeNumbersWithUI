using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersWithUI
{
    class PrimeCalculation
    {
        public static bool IsPrime(int aNumber)
        {
            if (aNumber <= 1) return false;
            if (aNumber == 2) return true;
            if (aNumber % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(aNumber));


            for (int i = 3; i <= boundary; i += 2)
            {
                if (aNumber % i == 0)
                    return false;
            }

            return true;
        }

        public static List<int> FindPrimesInACertainRange(int A, int B)
        {
            List<int> primesInTheRangeGiven = new List<int>();
            while (A <= B)
            {
                if (IsPrime(A) == true)
                {
                    primesInTheRangeGiven.Add(A);
                    A++;
                }
                
            }
            return primesInTheRangeGiven;

        }
    }
}
