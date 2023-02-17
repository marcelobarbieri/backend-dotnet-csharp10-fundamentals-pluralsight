using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    internal class Utilities
    {
        public static void ParsingStrings()
        {
            Console.Write("Enter the wage: ");
            string wage = Console.ReadLine();

            // int wageValue = int.Parse(wage);

            int wageValue;
            if (int.TryParse(wage, out wageValue))
                Console.WriteLine("Parsing success: " + wageValue);
            else
                Console.WriteLine("Parsing failed");

            /* Output:
             * 
             * Enter the wage: 123
             * Parsing success: 123
             * 
             * Enter the wage: abc
             * Parsing failed
             */

            string hireDateString = "12/12/2022";
            DateTime hireDate = DateTime.Parse(hireDateString);
            Console.WriteLine("Parsed date: " + hireDate);

            /* Output:
             * 
             * Parsed date: 12/12/2022 00:00:00
             */
        }
    }
}
