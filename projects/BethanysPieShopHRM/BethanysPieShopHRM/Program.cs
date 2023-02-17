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
Console.WriteLine($"Wage paid (message from Program): {receivedWageBethany}");

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
 * Wage paid (message from Program): 200
 */