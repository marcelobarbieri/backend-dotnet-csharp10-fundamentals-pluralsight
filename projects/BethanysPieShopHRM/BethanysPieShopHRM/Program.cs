int[] sampleArray1 = new int[5];
int[] sampleArray2 = new int[] {1,2,3,4,5};
// int[] sampleArray3 = new int[5] {1,2,3,4,5,6}; // An array initializer of lenght '5' is expected

Console.WriteLine("How many employee IDs do you want to register?");
int length = int.Parse(Console.ReadLine());
int[] employeeIds = new int[length];

var testId = employeeIds[0];
// var errorId = employeeIds[length]; // System.IndexOutOfRangeException - Index was outside the bounds of the array

for (int i = 0; i < length; i++)
{
    Console.Write("Enter the employee Id: ");
    int id = int.Parse(Console.ReadLine()); // let´s assum here that the user will always enter an int value
    employeeIds[i] = id;
}

for (int i = 0; i < employeeIds.Length; i++)
{
    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
}

/* Output:
 * 
 * How many employee IDs do you want to register?
 * 5
 * Enter the employee Id: 45
 * Enter the employee Id: 63
 * Enter the employee Id: 89
 * Enter the employee Id: 12
 * Enter the employee Id: 35
 * ID 1:   45
 * ID 2:   63
 * ID 3:   89
 * ID 4:   12
 * ID 5:   35
 */