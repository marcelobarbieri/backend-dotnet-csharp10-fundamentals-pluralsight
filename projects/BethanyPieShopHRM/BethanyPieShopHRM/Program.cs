using System.Diagnostics.Metrics;
using System.Net.Http.Headers;

Console.WriteLine("Enter the age of the new candidate: ");
int age = int.Parse(Console.ReadLine());

switch (age)
{
    case < 18:
        Console.WriteLine("Too young to apply");
        Console.WriteLine("Send email to candidate.");
        break;
    case > 65:
        Console.WriteLine("Sorry, the selected age is too old");
        Console.WriteLine("Send email to candidate.");
        break;
    default:
        Console.WriteLine("Great, you can now start with the application!");
        break;
}

//Enter the age of the new candidate:
//25
//Great, you can now start with the application!

switch (age)
{
    case < 18:
    case > 65:
        Console.WriteLine("Sorry, your age is not within the range we are looking for");
        break;
    case 23:
        Console.WriteLine("Wow, exactly what we are looking for");
        break;
    default:
        Console.WriteLine("Great, you can now start with the application!");
        break;
}


Console.WriteLine("Choose the action you want to do:");
Console.WriteLine("1. Add employee");
Console.WriteLine("2. Update employee");
Console.WriteLine("3. Delete employee");
string selectedAction = Console.ReadLine();

switch(selectedAction)
{
    case "1":
        Console.WriteLine("Adding new employee...");
        break;
    case "2":
        Console.WriteLine("Updating employee...");
        break;
    case "3":
        Console.WriteLine("Deleting employee...");
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}