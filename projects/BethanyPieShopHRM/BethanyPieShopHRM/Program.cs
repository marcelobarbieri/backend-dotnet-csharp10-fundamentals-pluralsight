using System.Diagnostics.Metrics;

Console.WriteLine("Enter the age of the new candidate: ");
int age = int.Parse(Console.ReadLine());

if (age < 18)
{
    Console.WriteLine("Too young to apply");
    Console.WriteLine("Send email to candidate.");
}
else if (age > 65)
{
    Console.WriteLine("Sorry, the selected age is too old");
    Console.WriteLine("Send email to candidate.");
}
else
{
    Console.WriteLine("Great, you can now start with the application!");
}

//Enter the age of the new candidate:
//15
//Too young to apply
//Send email to candidate.

//Enter the age of the new candidate:
//75
//Sorry, the selected age is too old
//Send email to candidate.

//Enter the age of the new candidate:
//25
//Great, you can now start with the application!

DateTime today = DateTime.Now;
bool endOfMonthPaymentStarted = false;

if (today.Date.Day == 20)
{
    Console.WriteLine("Please start end-of-month employee payments");
}
else if (today.Date.Day >= 25 && ! endOfMonthPaymentStarted)
{
    Console.WriteLine("Payments will be late!");
}
// else isn´t required!