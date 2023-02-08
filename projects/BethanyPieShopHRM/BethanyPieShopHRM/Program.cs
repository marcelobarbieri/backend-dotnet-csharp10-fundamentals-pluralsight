int bonus = 1000;

double ratePerHour = 12.34;
int numberOfHoursWorked = 165;

double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;
Console.WriteLine(currentMonthWage); // 3036,1

ratePerHour += 3; // ratePerHour = ratePerHour + 3;
Console.WriteLine(ratePerHour); // 15,34

if (currentMonthWage > 2000) // 3036,1
    Console.WriteLine("Top paid employee!");

int numberOfEmployees = 15;
numberOfEmployees--; // 14

bool a; // false
int b; // 0

Console.ReadLine();