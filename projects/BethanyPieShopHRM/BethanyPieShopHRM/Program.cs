int amount = 1234;
int months = 12;

int yearlyWage = CalculateYearlyWage(amount, months);

Console.WriteLine($"Yearly wage: {yearlyWage}");

Console.ReadLine();

static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
{
    if (numberOfMonthsWorked == 12) // let´s add a bonus month
        return monthlyWage * (numberOfMonthsWorked + 1);

    return monthlyWage * numberOfMonthsWorked;
}

/*
 * Output:
 * Yearly wage: 16042
 */