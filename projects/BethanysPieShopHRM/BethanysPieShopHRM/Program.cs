Console.WriteLine("How many employees IDs do you want to register?");

int length = int.Parse(Console.ReadLine());

int[] employeeIds = new int[length];

for (int i = 0; i < length; i++)
{
    Console.Write("Enter the employee ID: ");
    int id = int.Parse(Console.ReadLine());
    employeeIds[i] = id;
}

Console.WriteLine("Before sorting");
for (int i = 0; i < employeeIds.Length; i++)
    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");

Array.Sort(employeeIds);

Console.WriteLine("After sorting");
for (int i = 0; i < employeeIds.Length; i++)
    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");

int[] employeeIdsCopy = new int[length];
employeeIds.CopyTo(employeeIdsCopy, 0); 

Array.Reverse(employeeIds);

Console.WriteLine("After reversing original array");
for (int i = 0; i < employeeIds.Length; i++)
    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");

Console.WriteLine("Copy of array");
for (int i = 0; i < employeeIdsCopy.Length; i++)
    Console.WriteLine($"ID {i + 1}: \t{employeeIdsCopy[i]}");

/* Output:
 * 
 * How many employees IDs do you want to register?
 * 3
 * Enter the employee ID: 45
 * Enter the employee ID: 35
 * Enter the employee ID: 78
 * Before sorting
 * ID 1:   45
 * ID 2:   35
 * ID 3:   78
 * After sorting
 * ID 1:   35
 * ID 2:   45
 * ID 3:   78
 * After reversing original array
 * ID 1:   78
 * ID 2:   45
 * ID 3:   35
 * Copy of array
 * ID 1:   35
 * ID 2:   45
 * ID 3:   78
 */