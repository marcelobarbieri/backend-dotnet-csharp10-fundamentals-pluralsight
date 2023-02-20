using BethanysPieShopHRM;
using System.Collections.Generic;

Console.WriteLine("\n\nCreating an employee");
Console.WriteLine("--------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
bethany.DisplayEmployeeDetails();

bethany.PerformWork();
bethany.PerformWork(12);
bethany.PerformWork();

double receivedWageBethany = bethany.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from Program): {receivedWageBethany}");


Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);
george.DisplayEmployeeDetails();

george.PerformWork();
george.PerformWork();
george.PerformWork(3);
george.PerformWork();
george.PerformWork(8);

var receivedWageGeorge = george.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from Program): {receivedWageGeorge}");

/* Output:
 * 
 * Creating an employee
 * --------------------
 * 
 * First name:     Bethany
 * Last name:      Smith
 * E-mail:                 bethany @snowball.be
 * Birthday:       16/01/1979
 * 
 * Bethany Smith has worked for 1 hour(s)!
 * Bethany Smith has worked for 13 hour(s)!
 * Bethany Smith has worked for 14 hour(s)!
 * 
 * An extra was added to the wage since Bethany is a manager!
 * Bethany Smith has received a wage of 437,5 for 14 hour(s) of work.
 * Wage paid (message from Program): 437,5
 * 
 * 
 * Creating an employee
 * --------------------
 * 
 * First name:     George
 * Last name:      Jones
 * E-mail:                 george @snowball.be
 * Birthday:       28/03/1984
 * 
 * George Jones has worked for 1 hour(s)!
 * George Jones has worked for 2 hour(s)!
 * George Jones has worked for 5 hour(s)!
 * George Jones has worked for 6 hour(s)!
 * George Jones has worked for 14 hour(s)!
 * 
 * George Jones has received a wage of 420 for 14 hour(s) of work.
 * Wage paid (message from Program): 420
 */