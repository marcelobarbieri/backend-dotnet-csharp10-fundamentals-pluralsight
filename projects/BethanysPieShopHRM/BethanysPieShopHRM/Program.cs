using BethanysPieShopHRM.HR;

List<int> employeeIds = new List<int>();

employeeIds.Add(55);
employeeIds.Add(1);
employeeIds.Add(943);
employeeIds.Add(78);
employeeIds.Add(79);

// employeeIds.Add("test"); // Argument 1: cannot convert from 'string' to 'int'

if (employeeIds.Contains(78))
    Console.WriteLine("78 is found!");

int currentAmountOfEmployees = employeeIds.Count;

var employeeIdsArray = employeeIds.ToArray();

employeeIds.Clear();

Console.WriteLine("How many employees IDs do you want to register?");

int length = int.Parse(Console.ReadLine());

for (int i = 0; i < length; i++)
{
    Console.Write("Enter the employee ID: ");
    int id = int.Parse(Console.ReadLine());
    employeeIds.Add(id);
}

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);
Employee mary = new Employee("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30, EmployeeType.Manager);
Employee bobJunior = new Employee("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17, EmployeeType.Research);
Employee kevin = new Employee("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10, EmployeeType.StoreManager);
Employee kate = new Employee("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10, EmployeeType.StoreManager);
Employee kim = new Employee("Kim", "Jacobs", "kim@snowball.be", new DateTime(1975, 5, 14), 22, EmployeeType.StoreManager);

List<Employee> employees = new List<Employee>();
employees.Add(george);
employees.Insert(0, bethany);
employees.Add(mary);
employees.Add(bobJunior);
employees.Add(kevin);
employees.Add(kate);
employees.Add(kim);

foreach (Employee employee in employees)
{
    employee.DisplayEmployeeDetails();
}

/* Output:
 * 
 * 78 is found!
 * How many employees IDs do you want to register?
 * 3
 * Enter the employee ID: 14
 * Enter the employee ID: 78
 * Enter the employee ID: 96
 * 
 * First name:     Bethany
 * Last name:      Smith
 * E-mail:                 bethany@snowball.be
 * Birthday:       16/01/1979
 * Tax rate:       0,15
 * 
 * First name:     George
 * Last name:      Jones
 * E-mail:                 george@snowball.be
 * Birthday:       28/03/1984
 * Tax rate:       0,15
 * 
 * First name:     Mary
 * Last name:      Jones
 * E-mail:                 mary@snowball.be
 * Birthday:       16/01/1965
 * Tax rate:       0,15
 * 
 * First name:     Bob
 * Last name:      Spencer
 * E-mail:                 bob@snowball.be
 * Birthday:       23/01/1988
 * Tax rate:       0,15
 * 
 * First name:     Kevin
 * Last name:      Marks
 * E-mail:                 kevin@snowball.be
 * Birthday:       12/12/1953
 * Tax rate:       0,15
 * 
 * First name:     Kate
 * Last name:      Greggs
 * E-mail:                 kate@snowball.be
 * Birthday:       08/08/1993
 * Tax rate:       0,15
 * 
 * First name:     Kim
 * Last name:      Jacobs
 * E-mail:                 kim@snowball.be
 * Birthday:       14/05/1975
 * Tax rate:       0,15
 */