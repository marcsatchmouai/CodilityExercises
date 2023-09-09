using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBill
{
    public class SolutionAlt
    {
        public int solutionAlt(string E, string L)
        {
            int entranceFee = 2;
            int firstHourFee = 3;
            int nextHoursFee = 4;

            int totalCost = entranceFee + firstHourFee;

            TimeSpan entryTime = TimeSpan.Parse(E);
            TimeSpan exitTime = TimeSpan.Parse(L);

            int parkingMinutes = (int)(exitTime - entryTime).TotalMinutes;

            int extraTime = parkingMinutes - 60;

            if (extraTime > 0)
            {
                totalCost += extraTime / 60 * nextHoursFee;

                int extraMinutes = parkingMinutes % 60;

                if (extraMinutes > 0) totalCost += nextHoursFee;
            }
            
            return totalCost;
        }
    }
}
