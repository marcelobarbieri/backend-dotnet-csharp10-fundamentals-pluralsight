using BethanysPieShopHRM.HR;
using System.Collections.Generic;
using System.Reflection.Metadata;

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);
Employee mary = new Employee("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30, EmployeeType.Manager);
Employee bobJunior = new Employee("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17, EmployeeType.Research);
Employee kevin = new Employee("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10, EmployeeType.StoreManager);
Employee kate = new Employee("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10, EmployeeType.StoreManager);
Employee kim = new Employee("Kim", "Jacobs", "kim@snowball.be", new DateTime(1975, 5, 14), 22, EmployeeType.StoreManager);

Employee[] employees = new Employee[7];
employees[0] = bethany;
employees[1] = george;
employees[2] = mary;
employees[3] = bobJunior;
employees[4] = kevin;
employees[5] = kate;
employees[6] = kim;

foreach (Employee employee in employees)
{
    employee.DisplayEmployeeDetails();
    var numberOfHoursWorked = new Random().Next(25);
    employee.PerformWork(numberOfHoursWorked);
    employee.ReceiveWage();
}

/* Output:
 * 
 * First name:     Bethany
 * Last name:      Smith
 * E-mail:                 bethany @snowball.be
 * Birthday:       16/01/1979
 * Tax rate:       0,15
 * Bethany Smith has worked for 12 hour(s)!
 * An extra was added to the wage since Bethany is a manager!
 * Bethany Smith has received a wage of 318,75 for 12 hour(s) of work.
 * 
 * First name:     George
 * Last name:      Jones
 * E-mail:                 george @snowball.be
 * Birthday:       28/03/1984
 * Tax rate:       0,15
 * George Jones has worked for 21 hour(s)!
 * George Jones has received a wage of 535,5 for 21 hour(s) of work.
 * 
 * First name:     Mary
 * Last name:      Jones
 * E-mail:                 mary @snowball.be
 * Birthday:       16/01/1965
 * Tax rate:       0,15
 * Mary Jones has worked for 3 hour(s)!
 * An extra was added to the wage since Mary is a manager!
 * Mary Jones has received a wage of 95,625 for 3 hour(s) of work.
 * 
 * First name:     Bob
 * Last name:      Spencer
 * E-mail:                 bob @snowball.be
 * Birthday:       23/01/1988
 * Tax rate:       0,15
 * Bob Spencer has worked for 19 hour(s)!
 * Bob Spencer has received a wage of 274,55 for 19 hour(s) of work.
 * 
 * First name:     Kevin
 * Last name:      Marks
 * E-mail:                 kevin @snowball.be
 * Birthday:       12/12/1953
 * Tax rate:       0,15
 * Kevin Marks has worked for 23 hour(s)!
 * Kevin Marks has received a wage of 195,5 for 23 hour(s) of work.
 * 
 * First name:     Kate
 * Last name:      Greggs
 * E-mail:                 kate @snowball.be
 * Birthday:       08/08/1993
 * Tax rate:       0,15
 * Kate Greggs has worked for 3 hour(s)!
 * Kate Greggs has received a wage of 25,5 for 3 hour(s) of work.
 * 
 * First name:     Kim
 * Last name:      Jacobs
 * E-mail:                 kim @snowball.be
 * Birthday:       14/05/1975
 * Tax rate:       0,15
 * Kim Jacobs has worked for 14 hour(s)!
 * Kim Jacobs has received a wage of 261,8 for 14 hour(s) of work.
 */