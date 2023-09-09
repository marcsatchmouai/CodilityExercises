using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountConformingBitmasks
{
    public class Solution
    {
        public int solution(int A, int B, int C)
        {
            int count = 0;
            for (int i = 0; i < (1 << 30); i++)
            {
                if (((i & A) == A) || ((i & B) == B) || ((i & C) == C))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
