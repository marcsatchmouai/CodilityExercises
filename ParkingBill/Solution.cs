using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBill
{
    public class Solution
    {
        public int solution(string E, string L)
        {
            // Parse the entry and exit times
            TimeSpan entryTime = TimeSpan.Parse(E);
            TimeSpan exitTime = TimeSpan.Parse(L);

            // Calculate the time difference in minutes
            int timeDifferenceMinutes = (int)(exitTime - entryTime).TotalMinutes;

            // Calculate the total cost based on the billing rules
            int totalCost = 2; // Entrance fee

            if (timeDifferenceMinutes > 0)
            {
                totalCost += 3; // First hour

                // Calculate additional hours
                int additionalHours = (timeDifferenceMinutes - 60) / 60;
                if (additionalHours > 0)
                {
                    totalCost += additionalHours * 4;
                }

                // Check for a partial hour
                int remainingMinutes = timeDifferenceMinutes % 60;
                if (remainingMinutes > 0)
                {
                    totalCost += 4;
                }
            }

            return totalCost;
        }
    }
}
