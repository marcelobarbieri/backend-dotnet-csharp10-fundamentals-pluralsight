# C# 10 Fundamentals

by Gill Cleeren - [Pluralsight](https://www.pluralsight.com/)

https://app.pluralsight.com/library/courses/c-sharp-10-fundamentals/table-of-contents

> The content was organized in the _commits_

<!-- #region Course Overview -->

## Course Overview

<!-- #endregion -->

<!-- #region Getting Started with C# 10 and .NET 6 -->

## Getting Started with C# 10 and .NET 6

<!-- #region Module Introduction -->

<details>
<summary>Module Introduction</summary>
</details>

<!-- #endregion -->

<!-- #region Hello C# -->
<details>
<summary>Hello C#</summary>

<br/>

- C# is the main language for .NET development
- Object-oriented and type-safe programming language

<br/>

C# is actively mantained:
|Version|Year|
|---|---|
|1.0|2002|
|1.2|2003|
|2.0|2005|
|3.0|2007|
|4.0|2010|
|5.0|2012|
|6.0|2015|
|7.0|2017|
|8.0|2019|
|9.0|2020|
|10.0|2021|

</details>

<!-- #endregion -->

<!-- #region Setting up your environment -->

<details>
<summary>Setting up your environment</summary>

<br/>

Building .NET applications with C#:

- Visual Studio 2022 (Windows and Mac)
- .NET CLI and Visual Studio Code (all platforms)

<br/>

Introducing Visual Studio 2022:

- Flagship IDE (Integrated Development)
- Many features

<br/>

Visual Studio 2022 Editions:

- Community (free to use)
- Professional (paid, aimed at smaller teams)
- Enterprise (paid, aimed at larger teams)

</details>

<!-- #endregion -->

<!-- #region Demo: Setting up your environment using Visual Studio -->

<details>
<summary>Demo: Setting up your environment using Visual Studio</summary>

<br/>

</details>

<!-- #endregion -->

<!-- #region Building your first C# program using Visual Studio -->

<details>
<summary>Building your first C# program using Visual Studio</summary>

<br/>

Using projects:

- Containers for code files
- Compiled into executable files (assembly)
- Different templates

</details>

<!-- #endregion -->

<!-- #region Creating your first C# application -->

<details>
<summary>Creating your first C# application</summary>

<br/>

- Open Visual Studio 2022

![](./assets/open-visual-studio.png)

- Create a new project

![](./assets/create-a-new-project.png)

- Select C# language, **Console** project type and ConsoleApp (a project for creating a command-line application)

![](./assets/select-csharp-console.png)

- Configure your new project (Project name: HelloFromCSharp, location, solution name)

![](./assets/config-your-new-project.png)

- Additional information (framework .NET 6.0 LTS)

![](./assets/additional-information.png)

- Create and execute the project

![](./assets/execute-project.png)

</details>

<!-- #endregion -->

<!-- #region Demo: Writing C# Code -->

<details>
<summary>Demo: Writing C# Code</summary>

<br/>

Program.cs

```c#
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello everybody!");

Console.WriteLine("Please enter your name: ");
string name = Console.ReadLine();
Console.WriteLine($"Hello {name}");
```

Console

```ps
Hello everybody!
Please enter your name:
Marcelo
Hello Marcelo

D:\Dev\WIP\CSharp10 Fundamentals Pluralsight\projects\HelloFromCSharp\HelloFromCSharp\bin\Debug\net6.0\HelloFromCSharp.exe (process 22516) exited with code 0.
To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
Press any key to close this window . . .
```

</details>

<!-- #endregion -->

<!-- #region Demo: Exploring the Files in a C# application -->

<details>
<summary>Demo: Exploring the Files in a C# application</summary>

<br/>

Looking at the generated files

- Project
- Solution
- Executable file

Executing our compiled application

Solution Explorer

![](./assets/exploring-the-files.png)

</details>

<!-- #endregion -->

<!-- #region Debugging Our Code -->

<details>
<summary>Debugging Our Code</summary>

<br/>

Introducing Breakpoints

- Pause the running code
- Inspect the state of the running application
- Step through the different lines of code

Running with the Debugging Attached

![](./assets/running-debugging-attached.png)

</details>

<!-- #endregion -->

<!-- #region Demo: Debugging in Visual Studio -->

<details>
<summary>Demo: Debugging in Visual Studio</summary>

<br/>

Understanding the debugger

Tip: you can start your application with the debugger using F5

</details>

<!-- #endregion -->

<!-- #region Building Applications Using the CLI -->

<details>
<summary>Building Applications Using the CLI</summary>

<br/>

Understanding the CLI

- Command-line interface for .NET
- Cross-platform tools
- "dotnet" command with parameters

Install the .NET SDK

```ps
dotnet --list-sdks
```

Open the Windows Terminal

Creating a new project

```ps
dotnet new console -n "UnderstandingCLI"
```

| command      | description              |
| ------------ | ------------------------ |
| dotnet new   | create a new project     |
| dotnet build | compile your application |
| dotnet run   | execute your application |

</details>

<!-- #endregion -->

<!-- #region Demo: Using the Docs -->

<details>
<summary>Demo: Using the Docs</summary>

<br/>

Finding information in the docs:

https://learn.microsoft.com/pt-br/dotnet/csharp/

https://learn.microsoft.com/en-us/dotnet/api/

</details>

<!-- #endregion -->

<!-- #region Summary -->

<details>
<summary>Summary</summary>

<br/>

- C# is an object-oriented and type-safe language to write .NET applications
- C# is actively maintained
- C# can be uses to build all types of .NET applications
- Applications can be created using:

1. Visual Studio
2. CLI (combined with VS Code)

<br/>

</details>

<!-- #endregion -->

<!-- #endregion -->

<!-- #region Learning the C# Syntax -->

## Learning the C# Syntax

<!-- #region Module Introduction -->

<details>
<summary>Module Introduction</summary>

<br/>

Agenda:

- Understanding the essential C# building blocks
- Working with built-in types
- C# operators
- Using date and time
- Converting between types
- Implicit typing

</details>

<!-- #endregion -->

<!-- #region Understanding the Essential C# Building Blocks -->

<details>
<summary>Understanding the Essential C# Building Blocks</summary>

<br/>

C# Statements:

- Actions
- Flow of the program
- End with semicolon

```c#
Console.WriteLine("Hello, World!");
```

<br/>

C# Identifiers:

Identifiers start with a letter or underscore and can contain letters, digits and underscore.

```c#
string input = Console.ReadLine();
string 2_input = Console.ReadLine(); // wrong
```

<br/>

### C# Comments

- Single line comments:

Program.cs

```c#
// The next line will read a value from the console
string input = Console.ReadLine();
```

- Multiline comments:

Program.cs

```c#
/*
   In the next block of code,
   we will read a value from the console
 */
string input = Console.ReadLine();
```

<br/>

C# Keywords (about 70)

|         |          |
| ------- | -------- |
| `int`   | `ref`    |
| `in`    | `return` |
| `class` | `lock`   |
| `using` | `long`   |
| `while` | `string` |
| `new`   | `struct` |
| `null`  | `const`  |
| `if`    | `enum`   |
| `case`  | `void`   |

<br/>

C# Variables

|           |                                    |
| --------- | ---------------------------------- |
| _x_       | A variable holds a value           |
| _[1,2,3]_ | Integer, string, date ...          |
| {}        | Created in a declaration statement |

<br/>

Creating an Integer Variable

```c#
int age;
```

| Type | Identifier |
| ---- | ---------- |
| int  | age        |

<br/>

C# is case sensitive, diferente variables:

```c#
int age;
int Age;
```

<br/>

Camel Case:

Variable with many words.
The first word will always be lowercase and all subsequent words start with an uppercase.

```c#
int ageOfEmployee;
```

<br/>

Assignment a value to a variable:

```c#
int age;
age = 25;
```

| Assignment operator | Value |
| :-----------------: | :---: |
|         `=`         |  25   |

<br/>

Using the Variable:

```c#
Console.WriteLine(age);
```

</details>

<!-- #endregion -->

<!-- #region Demo: Using the Essential C# Building Blocks -->

<details>
<summary>Demo: Using the Essential C# Building Blocks</summary>

<br/>

Creating a new project called `BethanyPieShopHRM`

> [Projeto BethanyPieShopHRM](./projects/BethanyPieShopHRM/)

Program.cs

```c#
/*
 * Here are some tests around working with valid identifiers in C#
 * We can write here as much as we want, this is all comment
 */

Console.WriteLine("Welcome to Bethany's Pie Shop HRM");

Console.WriteLine("Please enter your name:");

//The following will accept the name
string name = Console.ReadLine();

string name2 = Console.ReadLine();

string name_2 = Console.ReadLine();

string Name_2 = Console.ReadLine();

//string 2Name = Console.ReadLine();
```

</details>

<!-- #endregion -->

<!-- #region Working with Built-in Types -->

<details>
<summary>Working with Built-in Types</summary>

<br/>

C# is a strongly type language:

- Every variable has a type
- Used to store information
- Expressions will return a value of a specified type

Using Data Types in C#:

- Size and location in memory
- Data range
- Supported operations

| Predefined types |
| ---------------- |
| bool             |
| int              |
| float            |
| double           |
| decimal          |
| char             |

| More Predefined Data Types |
| -------------------------- |
| byte (sbyte)               |
| short (ushort)             |
| object                     |
| string                     |

<br/>

Creating an Integer Value

```c#
int a = 2;
int b = a + 3;
```

| Expression |
| :--------: |
|   a + 3    |

Expression is a piece of code that will evaluate to a value.

<br/>

Creating a Boolean Value

```c#
bool c = true;
```

<br/>

C# Types Lead to Type Safety

```c#
int c = 3;
c = true; // wrong
```

</details>

<!-- #endregion -->

<!-- #region Demo: Working with Primitive Types -->

<details>
<summary>Demo: Working with Primitive Types</summary>

<br/>

Program.cs

```c#
int monthlyWage = 1234;

// monthlyWage = true; // wrong

int months = 12, bonus = 1000;

bool isActive = true;

double rating = 99.25;

byte numberOfEmployees = 155;


int hoursWorked;

hoursWorked = 125;
hoursWorked = 148;
```

</details>

<!-- #endregion -->

<!-- #region Demo: Using Constant Values -->

<details>
<summary>Demo: Using Constant Values</summary>

<br/>

Using a const value

```c#
const decimal interestRate = 0.07m;
```

Program.cs

```c#
const double interestRate = 0.07;

interestRate = 0.08;

// CS0131: The left-hand side of an assignment must be a variable, property or indexer
```

</details>

<!-- #endregion -->

<!-- #region Getting to Know Strings -->

<details>
<summary>Getting to Know Strings</summary>

<br/>

Understanding Strings

- Contains text
- Stored as list os char objects
- string type

Creating Basic Strings

```c#
string s1 = "Hello world";
string s2 = string.Empty;
```

</details>

<!-- #endregion -->

<!-- #region Demo: Creating Strings -->

<details>
<summary>Demo: Creating Strings</summary>

<br/>

Program.cs

```c#
string firstName = "Bethany";
string lastName = "Smith";

string emptyString = "";

Console.WriteLine("Please enter your name");
string name = Console.ReadLine();
```

</details>

<!-- #endregion -->

<!-- #region C# Operators -->

<details>
<summary>C# Operators</summary>

<br/>

Expressions in C#

Arithmetic expressions

```c#
int a, b, c;
a = 3;
b = 10;
c = a++;
b = a + b * c;
```

Operators:

- Arithmetic
- Equality
- Logical
- Assignment

Using Arithmetic Operators

| Operator | Example |
| :------: | :-----: |
|    +     |   a+b   |
|    -     |   a-3   |
|    \*    |  a*b*c  |
|    /     |  a/10   |
|    ++    |   a++   |
|    --    |   b--   |

Compound Assignment Operators

```c#
int month = 3;
month = month + 1;
month += 1; // compount assignment operator (pt-br, "operador de atribuição composto")
```

Operators Depend on the Type

```c#
string result1 = "a" + "b"; // concatenate
string result2 = "a" * "b"; // wrong
```

</details>

<!-- #endregion -->

<!-- #region Demo: Using Operators in C# -->

<details>
<summary>Demo: Using Operators in C#</summary>

<br/>

Using operators in C#

- Default values for types in C#

Program.cs

```c#
int bonus = 1000;

double ratePerHour = 12.34;
int numberOfHoursWorked = 165;

double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;
Console.WriteLine(currentMonthWage); // 3036,1

ratePerHour += 3; // ratePerHour = ratePerHour + 3;
Console.WriteLine(ratePerHour); // 15,34

if (currentMonthWage > 2000) // 3036,1
    Console.WriteLine("Top paid employee!");

int numberOfEmployees = 15;
numberOfEmployees--; // 14

bool a; // false
int b; // 0

Console.ReadLine();
```

Console

```ps
3036,1
15,34
Top paid employee!
```

</details>

<!-- #endregion -->

<!-- #region Members On Primitive Types -->

<details>
<summary>Members On Primitive Types</summary>

<br/>

Members On Primitive Types

```c#
int intMaxValue = int.MaxValue;
int intMinValue = int.MinValue;
double doubleMaxValue = double.MaxValue;
```

Member of char Type

```c#
char myChar = 'a';
bool isWhiteSpace = char.IsWhiteSpace(myChar);
bool isDigit = char.IsDigit(myChar);
bool isPunctuation = char.IsPunctuation(myChar);
```

</details>

<!-- #endregion -->

<!-- #region Demo: Working with Members On Primitive Types -->

<details>
<summary>Demo: Working with Members On Primitive Types</summary>

<br/>

Working with members of `int` and `char`

https://learn.microsoft.com/pt-br/dotnet/api/system.int32?view=net-6.0

Program.cs

```c#
int intMaxValue = int.MaxValue; // 2147483647
int intMinValue = int.MinValue; //-2147483648

char userSelection = 'a';
char upperVersion = char.ToUpper(userSelection); // 65 'A'

bool isDigit = char.IsDigit(userSelection); // false
bool isLetter = char.IsLetter(userSelection); // true

Console.ReadLine();
```

</details>

<!-- #endregion -->

<!-- #region Using Date and Time in C# -->

<details>
<summary>Using Date and Time in C#</summary>

<br/>

Working with Dates

- DateTime
- TimeSpan

Working with DateTime and DateOnly

```c#
DateTime employeesStartDate = new DateTime(2025,03,28);
DateTime today = DateTime.Today;
DateTime twoDaysLater = someDateTime.AddDays(2);
DayOfWeek day = someDateTime.DayOfWeek;
bool isDST = someDateTime.IsDaylightsSavingTime();
```

</details>

<!-- #endregion -->

<!-- #region Demo: Working with DateTime -->

<details>
<summary>Demo: Working with DateTime</summary>

<br/>

Program.cs

```c#
using System.Data;

DateTime hireDate = new DateTime(2022,3,28,14,30,0);
Console.WriteLine(hireDate); // 28/03/2022 14:30:00

DateTime exitDate = new DateTime(2025,12,11);

// DateTime invalidDate = new DateTime(2025,15,11);

DateTime startDate = hireDate.AddDays(15);
Console.WriteLine(startDate); // 12/04/2022 14:30:00

DateTime currentDate = DateTime.Now;
bool areWeInDst = currentDate.IsDaylightSavingTime();

DateTime startHour = DateTime.Now;
TimeSpan workTime = new TimeSpan(8,35,0);
DateTime endHour = startHour.Add(workTime);

Console.WriteLine(startHour); // 08/02/2023 20:49:32
Console.WriteLine(endHour); // 09/02/2023 05:24:32

Console.WriteLine(startHour.ToLongDateString()); // quarta-feira, 8 de fevereiro de 2023
Console.WriteLine(endHour.ToShortTimeString()); // 05:24

Console.ReadLine();
```

Console

```ps
28/03/2022 14:30:00
12/04/2022 14:30:00
08/02/2023 20:49:32
09/02/2023 05:24:32
quarta-feira, 8 de fevereiro de 2023
05:24
```

</details>

<!-- #endregion -->

<!-- #region Converting Between Types -->

<details>
<summary>Converting Between Types</summary>

<br/>

This Doesn´t Work...

```c#
int a = 3;
a = "Hello world";
```

Changing between Types

- Implicit conversion
- Casting Explicit conversion
- Helpers

Using an Implicit Cast

```c#
int a = 123456789;
long l = a;
```

Performing an Explicit Cast

```c#
double d = 123456789.0;
int a = (int) d;
```

</details>

<!-- #endregion -->

<!-- #region Demo: Converting Between Types -->

<details>
<summary>Demo: Converting Between Types</summary>

<br/>

Program.cs

```c#
int numberOfHoursWorked = 165;

long veryLongMonth = numberOfHoursWorked; // works fine

double d = 123456789.0;

int x = (int)d;

int intVeryLongMonth = (int)veryLongMonth;

Console.ReadLine();
```

</details>

<!-- #endregion -->

<!-- #region Implict Typing -->

<details>
<summary>Implicit Typing</summary>

<br/>

So Far, We´ve Used Explicit Typing

Explicit typing

```c#
int a = 123;
bool b = true;
double d = 11.0;
```

Implicit typing

```c#
var a = 123;  // a will be an integer
var b = true; // b will be a boolean
var d = 11.0; // d will be a double
```

Understanding Implicit Typing

- Type is inferred
- Not always as readable
- Sometimes required (using LINQ)

This Won´t Work...

```c#
var employeeAge;
```

</details>

<!-- #endregion -->

<!-- #region Demo: Using var -->

<details>
<summary>Demo: Using var</summary>

<br/>

Program.cs

```c#
var monthlyWage = 1234; // integer
var isActive = true; // boolean
var rating = 99.25; // double
var numberOfEmployees = 300; // integer
var hireDate = new DateTime(2022,3,28,14,30,0); // DateTime
```

</details>

<!-- #endregion -->

<!-- #region Summary -->

<details>
<summary>Summary</summary>

<br/>

- C# is a strongly typed language
- Contains built-in data types
- Conversion between types is supported

</details>

<!-- #endregion -->

<!-- #endregion -->

<!-- #region Adding Decision and Iteration Statements in C# -->

## Adding Decision and Iteration Statements in C#

<!-- #region Module Introduction -->

<details>
<summary>Module Introduction</summary>

<br/>

Agenda:

- Working with Boolean values
- Making decisions with the `if` statement
- Using the `switch` statement
- Adding iterations

</details>

<!-- #endregion -->

<!-- #region Working with Boolean Values -->

<details>
<summary>Working with Boolean Values</summary>

<br/>

Boolean Values

- True or false
- bool type (Boolean backing type)
- Boolean operators

Using a Boolean Value

```c#
bool c = true;
Console.WriteLine(c); // Writes True to the console
```

Using Relational Operators

| Operator | Example |
| :------: | :-----: |
|    ==    | a == b  |
|    !=    | a != b  |
|  > or <  | a > 10  |
| >= or <= | a <= 5  |

Using Logical Operators

```c#
age == 45; // True if value of age is effectively equal to 45, otherwise false
age != 0; // True if age is not equal to 0
```

Using Boolean Logical Operators: &&

```c#
bool validAge;
validAge = (age >= 18) && (age <= 65>);
// && - True if either of the expressions is true, otherwise false
```

Using Boolean Logical Operators: ||

```c#
bool validAge;
validAge = (age >= 18 ||) (age <= 65);
// || - True if any of the expressions is true, false only if both are false
```

</details>

<!-- #endregion -->

<!-- #region Demo: Working with Relational Operators -->

<details>
<summary>Demo: Working with Relational Operators</summary>

<br/>

Using Boolean logical operators

Program.cs

```c#
int age = 23;

bool a = age == 23;
Console.WriteLine("Age is 23: " + a);

bool b = age >= 23;
Console.WriteLine("Age is greater than 23: " + b);

bool c = (age >= 18) && (age <= 65);
Console.WriteLine("Age is between 18 and 65: " + c);

int age1 = 16;
int age2 = 64;
bool d = (age1 >= 18) && (age2 <= 65);
Console.WriteLine("Age1 is greater than 18 AND age2 is less than 65: " + d);
bool e = (age1 >= 18) || (age2 <= 65);
Console.WriteLine("Age1 is greater than 18 OR age2 is less than 65: " + e);
```

Console

```ps
Age is 23: True
Age is greater than 23: True
Age is between 18 and 65: True
Age1 is greater than 18 AND age2 is less than 65: False
Age1 is greater than 18 OR age2 is less than 65: True
```

</details>

<!-- #endregion -->

<!-- #region Making Decisions with the if Statement -->

<details>
<summary>Making Decisions with the if Statement</summary>

<br/>

Flow of Execution

- Won´t be a straight path
- Depends on values
- Different logic needs to be executed

A New Requirement

- If the person applying for the job is under 18, we can´t hire them
- If the person applying is older than 65 we can´t hire them

Structure of an if Statement

```c#
if (some Boolean expression)
{
  // Other statements
}
else
{
  // Other statements
  // The else block is optional
}
```

Using an if Statement

```c#
if (age < 18)
{
  Console.WriteLine("Too young to apply");
}
```

```c#
if (age < 18)
{
  Console.WriteLine("Too young to apply");
}
else
{
  Console.WriteLine("Great, you can now start with your application!");
}
```

```c#
if (age < 18)
  Console.WriteLine("Too young to apply");
else
  Console.WriteLine("Great, you can now start with your application!");
```

This Won´t Work

```c#
if (age < 18)
  Console.WriteLine("Too young to apply");
  Console.WriteLine("Please try again later!");
  // We need curly braces here!
else
  Console.WriteLine("Great, you can continue!");
```

```c#
if (age = 100)
{
  // Send mail
}
```

Adding Multiple Conditions

```c#
if (some Boolean expression)
{
  // Other statements
}
else if (other Boolean expression)
{
  // Other statements
}

...

else
{
  // Other statements
}
```

Using an else if Block

```c#
if (age < 18)
{
  Console.WriteLine("You young to apply");
}
else if (age > 65)
{
  Console.WriteLine("Sorry, the selected age is too old");
}
else
{
  Console.WriteLine("Great, you can continue!");
}
```

</details>

<!-- #endregion -->

<!-- #region Demo: Using if Statements -->

<details>
<summary>Demo: Using if Statements</summary>

<br/>

Program.cs

```c#
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
```

Console

```ps
Enter the age of the new candidate:
15
Too young to apply
Send email to candidate.

Enter the age of the new candidate:
75
Sorry, the selected age is too old
Send email to candidate.

Enter the age of the new candidate:
25
Great, you can now start with the application!
```

Program.cs

```c#
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
```

</details>

<!-- #endregion -->

<!-- #region Using switch Statement -->

<details>
<summary>Using switch Statement</summary>

<br/>

Too Many Options...

```c#
if (condition 1)
  ...
else if (condition 2)
  ...
else if (condition 3)
  ...
else if (condition 4)
  ...
else if (condition 5)
  ...
else if (condition 6)
  ...
...
else
  ...
```

Structure of a swith Statement

```c#
switch(expression)
{
  case constant expression1:
    // Other statements
    break;
  case relational expression2:
    // Other statements
    break;

  ...

  default:
    // Other statements
    break;
}
```

Using a swith Statement

```c#
swith (age)
{
  case < 18:
    Console.WriteLine("Too young to apply");
    break;
  case > 65:
    Console.WriteLine("Sorry, the selected age is too old");
    break;
  case 42:
    Console.WriteLine("Wow, exactly what we are looking for");
    break;
  default:
    Console.WriteLine("Great, you can continue");
    break;
}
```

- Works for most data types but not for `float` and `double`
- Case labels use a pattern: constant or relational
- Each case must be unique
- First "true" will get executed (top to bottom)
- Default can be placed wherever we want, always evaluated last

</details>

<!-- #endregion -->

<!-- #region Demo Using switch Statement -->

<details>
<summary>Demo Using switch Statement</summary>

Program.cs

```c#
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
```

Program.cs

```c#
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
```

Program.cs

```c#
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
```

<br/>

</details>

<!-- #endregion -->

<!-- #region Adding Iterations -->

<details>
<summary>Adding Iterations</summary>

<br/>

The Need for Iterations

- Continue executing a task (looping)
- Ofter used in combination with counter
- Ask input until stop is reached
- Keep reading files from disk

Loop Options in C#

- while
- do-while
- for

Creating a while loop

```c#
while(Boolean expression)
{
  // statements
}
```

- Condition is tested before the loop runs
- Statements will get executed as long as expression is true
- Braces are required if more than one statement must be executed
- We can create infinite loops!

```c#
int i = 0;

while (i < 10>)
{
  Console.WriteLine(i);
  i++;
}
```

```ps
Output:
0
1
2
3
4
5
6
7
8
9
```

</details>

<!-- #endregion -->

<!-- #endregion -->
