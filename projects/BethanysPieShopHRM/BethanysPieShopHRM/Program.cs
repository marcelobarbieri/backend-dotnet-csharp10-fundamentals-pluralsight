using BethanysPieShopHRM;

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.br", new DateTime(1979,1,16), 25);
bethany.DisplayEmployeeDetails();


bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();

double receivedWageBethany = bethany.ReceiveWage(true);
Console.WriteLine($"Wage paid for Bethany (message from Program): {receivedWageBethany}");

Console.WriteLine("\nCreating an employee");
Console.WriteLine("--------------------\n");

Employee george = new("George", "Jones", "george@snowball.br", new DateTime(1984,3,28), 30);
george.DisplayEmployeeDetails();

george.PerformWork();
george.PerformWork();
george.PerformWork(3);
george.PerformWork();
george.PerformWork(8);

var receiveWageGeorge = george.ReceiveWage(true);
Console.WriteLine($"Wage paid for George (message from Program): {receivedWageBethany}");

/* Output
 * 
 * Creating an employee
 * --------------------
 * 
 * First name:     Bethany
 * Last name:      Smith
 * E-mail:                 bethany@snowball.br
 * Birthday:       16/01/1979
 * 
 * Bethany Smith has worked for 1 hour(s)!
 * Bethany Smith has worked for 2 hour(s)!
 * Bethany Smith has worked for 7 hour(s)!
 * Bethany Smith has worked for 8 hour(s)!
 * Bethany Smith has received a wage of 200 for 8 hour(s) of work.
 * Wage paid for Bethany (message from Program): 200
 * 
 * Creating an employee
 * --------------------
 * 
 * First name:     George
 * Last name:      Jones
 * E-mail:                 george@snowball.br
 * Birthday:       28/03/1984
 * 
 * George Jones has worked for 1 hour(s)!
 * George Jones has worked for 2 hour(s)!
 * George Jones has worked for 5 hour(s)!
 * George Jones has worked for 6 hour(s)!
 * George Jones has worked for 14 hour(s)!
 * George Jones has received a wage of 420 for 14 hour(s) of work.
 * Wage paid for George (message from Program): 200
 */