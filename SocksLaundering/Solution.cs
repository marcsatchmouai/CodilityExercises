using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocksLaundering
{
    public class Solution
    {
        public int solution(int K, int[] C, int[] D)
        {
            int maxColor = 50; // El rango máximo de colores
            int[] cleanSockCounts = new int[maxColor + 1];
            int[] dirtySockCounts = new int[maxColor + 1];

            // Contar la cantidad de calcetines limpios y sucios para cada color
            foreach (int color in C)
            {
                cleanSockCounts[color]++;
            }

            foreach (int color in D)
            {
                dirtySockCounts[color]++;
            }

            int maxPairs = 0;

            for (int color = 1; color <= maxColor; color++)
            {
                int cleanCount = cleanSockCounts[color];
                int dirtyCount = dirtySockCounts[color];

                int pairsFromCleanSocks = cleanCount / 2;
                int pairsFromDirtySocks = Math.Min((dirtyCount / 2) * 2, K - (cleanCount % 2));

                int totalPairs = pairsFromCleanSocks + pairsFromDirtySocks;

                maxPairs += totalPairs;
            }

            return maxPairs;



        }
    }
}
