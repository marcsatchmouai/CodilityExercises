using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParityDegree
{
    public class Solution
    {
        public int solution(int N)
        {
            int highestPowerOf2 = 0;

            while (N % 2 == 0)
            {
                N /= 2;
                highestPowerOf2++;
            }

            return highestPowerOf2;
        }
    }
}
