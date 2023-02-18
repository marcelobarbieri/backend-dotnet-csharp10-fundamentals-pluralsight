using BethanysPieShopHRM;
using System.Collections.Generic;
using System.Xml.Linq;

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.br", new DateTime(1979,1,16), 25);

bethany.PerformWork(25);

int minimumBonus = 100;
int bonusTax;
int receivedBonus = bethany.CalculatedBonusAndBonusTaxOut(minimumBonus, out bonusTax);
Console.Write($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {bethany.firstName} has received a bonus of {receivedBonus}");

/* Output:
 * 
 * Creating an employee
 * --------------------
 * 
 * Bethany Smith has worked for 25 hour(s)!
 * The employee got a bonus of 180 and the tax on the bonus is 20
 * The minimum bonus is 100, the bonus tax is 20 and Bethany has received a bonus of 180
 */