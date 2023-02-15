using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    internal class Utilities
    {
        public static void UsingNamedArguments()
        {
            int amount = 1234;
            int months = 12;
            int bonus = 500;

            int yearlyWageForEmployee = CalculateYearlyWageWithNamed(
                bonus: bonus,
                monthlyWage: amount,
                numberOfMonthsWorked: months);

            Console.WriteLine($"Yearly wage for employee (Bethany): {yearlyWageForEmployee}");
        }

        public static int CalculateYearlyWageWithNamed (
            int monthlyWage, 
            int numberOfMonthsWorked, 
            int bonus)
        {
            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
    }
}
