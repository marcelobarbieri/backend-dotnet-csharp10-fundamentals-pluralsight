using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    internal class Utilities
    {
        public static void UsingEscapeCharacters()
        {
            string firstName = "Bethany";
            string lastName = "Smith";

            string displayName = $"Welcome!\n{firstName}\t{lastName}";
            Console.WriteLine(displayName);

            /*
             * Output:
             * 
             * Welcome!
             * Bethany Smith
             */

            // string invalidFilePath = "C:\data\employeelist.xlsx";
            // string filePath = "C:\\data\\employeelist.xlsx";
            string filePath = @"C:\data\employeelist.xlsx";

            string marketingTagLine = "Baking the \"best pies\" ever";
        }
    }
}
