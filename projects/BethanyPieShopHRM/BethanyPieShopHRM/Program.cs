using BethanyPieShopHRM;

int amount = 1234;
int months = 12;

int yearlyWage = Utilities.CalculateYearlyWage(amount, months);

Console.WriteLine($"Yearly wage: {yearlyWage}");

Console.ReadLine();

/*
 * Output:
 * Yearly wage: 16042
 */