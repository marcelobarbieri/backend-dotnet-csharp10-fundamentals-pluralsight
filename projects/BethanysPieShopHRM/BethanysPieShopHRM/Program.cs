using BethanysPieShopHRM.HR;
using System.Collections.Generic;
using System.Xml.Linq;

Console.WriteLine("Creating Bethany Employee\n");
Employee bethany = new Employee("Bethany", "Smith" , "bethany@snowball.be", new DateTime(1979,1,16), 25, EmployeeType.Manager);

Console.WriteLine("Creating George Employee\n");
Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);

#region First run Bethany

Console.WriteLine("First run Betany");

bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();

bethany.ReceiveWage();

bethany.DisplayEmployeeDetails();

#endregion

#region First run George

Console.WriteLine("First run George");

george.PerformWork(10);
george.PerformWork();
george.PerformWork();

george.ReceiveWage();

george.DisplayEmployeeDetails();

#endregion

Console.WriteLine("\ntaxRate changed to 0.02\n");
Employee.taxRate = 0.02;

#region Second run Bethany

Console.WriteLine("Second run Betany");

bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork();

bethany.ReceiveWage();

bethany.DisplayEmployeeDetails();

#endregion

#region Second run George

Console.WriteLine("Second run George");

george.PerformWork();
george.PerformWork();
george.PerformWork();
george.PerformWork();

george.ReceiveWage();

george.DisplayEmployeeDetails();

#endregion

Employee.DisplayTaxRate();

/* Output:
 * 
 * Creating Bethany Employee
 * 
 * Creating George Employee
 * 
 * First run Betany
 * Bethany Smith has worked for 1 hour(s)!
 * Bethany Smith has worked for 6 hour(s)!
 * Bethany Smith has worked for 7 hour(s)!
 * An extra was added to the wage since Bethany is a manager!
 * Bethany Smith has received a wage of 185,9375 for 7 hour(s) of work.
 * 
 * First name:     Bethany
 * Last name:      Smith
 * E-mail:                 bethany @snowball.be
 * Birthday:       16/01/1979
 * Tax rate:       0,15
 * 
 * First run George
 * George Jones has worked for 10 hour(s)!
 * George Jones has worked for 11 hour(s)!
 * George Jones has worked for 12 hour(s)!
 * George Jones has received a wage of 306 for 12 hour(s) of work.
 * 
 * First name:     George
 * Last name:      Jones
 * E-mail:                 george @snowball.be
 * Birthday:       28/03/1984
 * Tax rate:       0,15
 * 
 * taxRate changed to 0.02
 * 
 * Second run Betany
 * Bethany Smith has worked for 1 hour(s)!
 * Bethany Smith has worked for 2 hour(s)!
 * Bethany Smith has worked for 3 hour(s)!
 * Bethany Smith has worked for 4 hour(s)!
 * Bethany Smith has worked for 5 hour(s)!
 * Bethany Smith has worked for 6 hour(s)!
 * Bethany Smith has worked for 7 hour(s)!
 * An extra was added to the wage since Bethany is a manager!
 * Bethany Smith has received a wage of 214,375 for 7 hour(s) of work.
 * 
 * First name:     Bethany
 * Last name:      Smith
 * E-mail:                 bethany @snowball.be
 * Birthday:       16/01/1979
 * Tax rate:       0,02
 * 
 * Second run George
 * George Jones has worked for 1 hour(s)!
 * George Jones has worked for 2 hour(s)!
 * George Jones has worked for 3 hour(s)!
 * George Jones has worked for 4 hour(s)!
 * George Jones has received a wage of 117,6 for 4 hour(s) of work.
 * 
 * First name:     George
 * Last name:      Jones
 * E-mail:                 george @snowball.be
 * Birthday:       28/03/1984
 * Tax rate:       0,02
 */