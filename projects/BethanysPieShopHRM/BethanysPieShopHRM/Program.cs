using BethanysPieShopHRM;
using System.Collections.Generic;
using System.Xml.Linq;

int a = 42;
int aCopy = a;
Console.WriteLine($"Value of a: {a} and value of copy of a: {aCopy}");
aCopy = 100;
Console.WriteLine($"Value of a: {a} and value of copy of a: {aCopy}");

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.br", new DateTime(1979,1,16), 25);
Employee testEmployee = bethany;
testEmployee.firstName = "Gill";
testEmployee.DisplayEmployeeDetails();
bethany.DisplayEmployeeDetails();

/* Output:
 * 
 * Value of a: 42 and value of copy of a: 42
 * Value of a: 42 and value of copy of a: 100
 * 
 * Creating an employee
 * --------------------
 * First name:     Gill
 * Last name:      Smith
 * E-mail:                 bethany @snowball.br
 * Birthday:       16/01/1979
 * 
 * First name:     Gill
 * Last name:      Smith
 * E-mail:                 bethany @snowball.br
 * Birthday:       16/01/1979
 */