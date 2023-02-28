using BethanysPieShopHRM.HR;
using System.Collections.Generic;
using System.Reflection.Metadata;

IEmployee bethany = new StoreManager("Bethany","Smith","bethany@snowball.be", new DateTime(1979,1,16),25);
IEmployee mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965,1,16), 30);
IEmployee bobJunior = new JuniorResearcher("Bob","Spencer","bob@snowball.be", new DateTime(1988,1,23),17);
IEmployee kevin = new StoreManager("Kevin","Marks","kevin@snowball.be",new DateTime(1953,12,12),10);
IEmployee kate = new StoreManager("Kate","Greggs","kate@snowball.be", new DateTime(1993,8,8),10);

List<IEmployee> employees = new List<IEmployee>();
employees.Add(bethany);
employees.Add(mary);
employees.Add(bobJunior);
employees.Add(kevin);
employees.Add(kate);

foreach(Employee employee in employees)
{
    employee.DisplayEmployeeDetails();
    employee.GiveBonus();
    employee.GiveCompliment();
}

/* Output: 
 

First name:     Bethany
Last name:      Smith
E-mail:                 bethany@snowball.be
Birthday:       16/01/1979
Tax rate:       0,15
Bethany Smith received a generic bonus of 100!
Youpve done a great job, Bethany

First name:     Mary
Last name:      Jones
E-mail:                 mary@snowball.be
Birthday:       16/01/1965
Tax rate:       0,15
Manager Mary Jones received a management bonus of 250!
Youpve done a great job, Mary

First name:     Bob
Last name:      Spencer
E-mail:                 bob@snowball.be
Birthday:       23/01/1988
Tax rate:       0,15
Bob Spencer received a generic bonus of 100!
Youpve done a great job, Bob

First name:     Kevin
Last name:      Marks
E-mail:                 kevin@snowball.be
Birthday:       12/12/1953
Tax rate:       0,15
Kevin Marks received a generic bonus of 100!
Youpve done a great job, Kevin

First name:     Kate
Last name:      Greggs
E-mail:                 kate@snowball.be
Birthday:       08/08/1993
Tax rate:       0,15
Kate Greggs received a generic bonus of 100!
Youpve done a great job, Kate

*/