using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    internal class Utilities
    {
        public static void ManipulatingStrings()
        {
            string firstName = "Bethany";
            string lastName = "Smith";

            string fullName = firstName + " " + lastName;
            string employeeIdentification = String.Concat(firstName,lastName);

            string empId = firstName.ToLower() + "-" + lastName.Trim().ToLower();

            int lenght = empId.Length;

            if (fullName.Contains("beth") || fullName.Contains("Beth"))
            {
                Console.WriteLine("It´s Bethany!");
            }

            string subString = fullName.Substring(1, 3);
            Console.WriteLine("Characters 2 to 4 of fullName are " + subString);

            string userNameWithInterpolation = $"{firstName}-{lastName}";

            /* Output:
             * It´s Bethany!
             * Characters 2 to 4 of fullName are eth
             */
        }
    }
}
