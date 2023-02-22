using BethanysPieShopHRM.HR;

List<Employee> employess = new List<Employee>();
for (int i = 0;i < 5000000; i++)
{
    Employee randomEmploye = new Employee(
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
        new DateTime(1979, 1, 16),
        null,
        EmployeeType.StoreManager);
    employess.Add(randomEmploye);
}

employess.Clear();
employess = null;

GC.Collect();

Console.ReadLine();