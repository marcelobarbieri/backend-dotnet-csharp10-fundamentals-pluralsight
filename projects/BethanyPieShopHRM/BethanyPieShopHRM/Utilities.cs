using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    internal class Utilities
    {
        public static void UsingExpressionBodiedSyntax()
        {
            int amount = 1234;
            int months = 12;
            int bonus = 500;

            int yearlyWageForEmployee = CalculateYearlyWageWithExpressionBodied(amount, months, bonus);

            Console.WriteLine($"Yearly wage for employee (Bethany): {yearlyWageForEmployee}");
        }

        public static int CalculateYearlyWageWithExpressionBodied(
            int monthlyWage,
            int numberOfMonthsWorked,
            int bonus) => monthlyWage * numberOfMonthsWorked + bonus;
    }
}
