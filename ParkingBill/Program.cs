using ParkingBill;

SolutionAlt S = new SolutionAlt();
string entryTime = "17:00";
string exitTime = "18:48";
int cost = S.solutionAlt(entryTime, exitTime);
Console.WriteLine(cost); // This should output 17
