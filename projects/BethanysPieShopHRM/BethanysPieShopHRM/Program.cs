using BethanysPieShopHRM;

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee bethany = new Employee("Bethany","Smith","bethany@snowball.br", new DateTime(1979,1,16),25);

string bethanyAsJson = bethany.ConvertToJson();
Console.WriteLine(bethanyAsJson);

/* Output:
 * 
 * Creating an employee
 * --------------------
 * 
 * {"firstName":"Bethany","lastName":"Smith","email":"bethany@snowball.br","numberOfHoursWorked":0,"wage":0.0,"hourlyRate":25.0,"birthDay":"1979-01-16T00:00:00"}
 */