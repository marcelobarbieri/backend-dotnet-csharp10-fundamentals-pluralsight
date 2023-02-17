using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    internal class Utilities
    {
        public static void UsingStringEquality()
        {
            string name1 = "Bethany";
            string name2 = "BETHANY";

            Console.WriteLine("Are both names equal? " + (name1 == name2));
            Console.WriteLine("Is name equal to Bethany? " + (name1 == "Bethany"));
            Console.WriteLine("Is name equal to BETHANY? " + (name2.Equals("BETHANY")));
            Console.WriteLine("Is lowercase name equal to bethany? " + (name1.ToLower() == "bethany"));
            /*
             * Output:
             * 
             * Are both names equal? False
             * Is name equal to Bethany? True
             * Is name equal to BETHANY? True
             * Is lowercase name equal to bethany? True
             */
        }
    }
}
