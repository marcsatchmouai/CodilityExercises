using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeLetters
{
    public class Solution
    {
        public string solution(int A, int B) 
        {
            char charA = 'a';
            char charB = 'b';
            StringBuilder result = new StringBuilder();

            while (A > 0 || B > 0)
            {
                if (A > B)
                {
                    if (result.Length >= 2 && result[result.Length - 1] == charA && result[result.Length - 2] == charA)
                    {
                        result.Append(charB);
                        B--;
                    }
                    else
                    {
                        result.Append(charA);
                        A--;
                    }
                }
                else
                {
                    if (result.Length >= 2 && result[result.Length - 1] == charB && result[result.Length - 2] == charB)
                    {
                        result.Append(charA);
                        A--;
                    }
                    else
                    {
                        result.Append(charB);
                        B--;
                    }
                }
            }

            return result.ToString();
        }
    }
}
