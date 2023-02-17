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

<!-- #region Demo Creating a while Loop -->

<details>
<summary>Demo Creating a while Loop</summary>

<br/>

Creating a while loop

Program.cs

```c#
using System.Transactions;

Console.WriteLine("Enter a value: ");
int max = int.Parse(Console.ReadLine());

int i = 0;

while (i < max)
{
    Console.WriteLine(i);
    i++;
}

Console.WriteLine("Loop finished!");
```

Console

```ps
Enter a value:
5
0
1
2
3
4
Loop finished!
```

Program.cs

```c#
int i = 10;

while(i>0)
{
    Console.WriteLine(i);
    i--;
}

Console.WriteLine("Loop finished!")
```

Console

```ps
10
9
8
7
6
5
4
3
2
1
Loop finished!
```

Program.cs

```c#
Console.WriteLine("Choose the action you want to do: ");
Console.WriteLine("1. Add employee");
Console.WriteLine("2. Update employee");
Console.WriteLine("3. Delete employee");
Console.WriteLine("99. Exit application");
string selectedAction = Console.ReadLine();

while (selectedAction != "99")
{
    switch (selectedAction)
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
    Console.WriteLine("Choose the action you want to do: ");
    Console.WriteLine("1. Add employee");
    Console.WriteLine("2. Update employee");
    Console.WriteLine("3. Delete employee");
    Console.WriteLine("99. Exit application");
    selectedAction = Console.ReadLine();
}

Console.WriteLine("Closing application");
```

Console

```ps
Choose the action you want to do:
1. Add employee
2. Update employee
3. Delete employee
99. Exit application
1
Adding new employee...
Choose the action you want to do:
1. Add employee
2. Update employee
3. Delete employee
99. Exit application
2
Updating employee...
Choose the action you want to do:
1. Add employee
2. Update employee
3. Delete employee
99. Exit application
3
Deleting employee...
Choose the action you want to do:
1. Add employee
2. Update employee
3. Delete employee
99. Exit application
99
Closing application
```

<br/>

Creating a nested loop

Program.cs

```c#
int i = 0;
int j = 0;

while (i < 3)
{
    while(j < 3)
    {
        Console.WriteLine("i: " + i + "   j: " + j);
        j++;
    }
    j = 0;
    i++;
}
```

Console

```ps
i: 0   j: 0
i: 0   j: 1
i: 0   j: 2
i: 1   j: 0
i: 1   j: 1
i: 1   j: 2
i: 2   j: 0
i: 2   j: 1
i: 2   j: 2
```

</details>

<!-- #endregion -->

<!-- #region Using the do while and the for loop -->

<details>
<summary>Using the do while and the for loop</summary>

<br/>

Creating a do-while loop

```c#
do{
  //statements
}
while(Boolean expression);
```

```c#
int i = 0;
do
{
  Console.WriteLine(i);
  i++;
} while (i < 10);
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

```c#
int i = 10;
do
{
  Console.WriteLine(i);
  i++;
} while (i < 10);
```

```ps
Output:
10
```

<br/>

Creating a for Loop

```c#
for (initialization; Boolean; iterator)
{
  // statements
}
```

```c#
int sum = 0;

for (int i = 0; i < 10; i ++)
{
sum = sum + i;
}

Console.WriteLine(sum);
```

</details>

<!-- #endregion -->

<!-- #region Demo More Loops -->

<details>
<summary>Demo More Loops</summary>

<br/>

- Creating more loops
- Adding break and continue
- Debugging loops

Refactoring (`do while` instead of `while`)

```c#
string selectedAction;
do
{
    Console.WriteLine("Choose the action you want to do: ");
    Console.WriteLine("1. Add employee");
    Console.WriteLine("2. Update employee");
    Console.WriteLine("3. Delete employee");
    Console.WriteLine("99. Exit application");
    selectedAction = Console.ReadLine();

    switch (selectedAction)
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

} while (selectedAction != "99");

Console.WriteLine("Closing application");
```

for

```c#
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
```

Continue

```c#
Console.WriteLine("Enter a value: ");
int max = int.Parse(Console.ReadLine());

for (int i = 0; i < max; i++)
{
    if (i == 5)
    {
        Console.WriteLine("Bingo! " + i + " was found!");
        continue;
    }
    Console.WriteLine(i);
}

/*
Enter a value:
10
0
1
2
3
4
Bingo! 5 was found!
6
7
8
9
*/

```

Break

```c#
Console.WriteLine("Enter a value: ");
int max = int.Parse(Console.ReadLine());

for (int i = 0; i < max; i++)
{
    if (i == 5)
    {
        Console.WriteLine("Bingo! " + i + " was found!");
        break;
    }
    Console.WriteLine(i);
}

/*
Enter a value:
10
0
1
2
3
4
Bingo! 5 was found!
*/
```

</details>

<!-- #endregion -->

<!-- #region Summary -->

<details>
<summary>Summary</summary>

<br/>

- Our C# code will need to follow different paths
- if and switch statements allow to evaluate values
- while, do-while and for create iterations

</details>

<!-- #endregion -->

<!-- #endregion -->

<!-- #region Using Methods in C# -->

## Using Methods in C#

<!-- #region Module Introduction -->

<details>
<summary>Module Introduction</summary>

<br/>

- Understanding methods
- Adding a helper file
- Finding the correct method
- Understanding variable scope
- More options with methods
- Introducing the Main method

</details>

<!-- #endregion -->

<!-- #region Understanding Methods -->

<details>
<summary>Understanding Methods</summary>

<br/>

Our current code...

- Is one large block
- Some code can be reused multiple times though
- Using methods will help
- Similar to functions or subroutines

Methods in C#

- Code block
- Receives parameters and (optionally) returns value
- Readable code and code reuse
- Declared within a class or struct

C# Methods Syntax

```c#
<access modifier> <return type> Method_Name (Parameters)
{
  // method statements
}
```

Looking at a First Method

```c#
public int AddTwoNumbers()
{

}
```

Adding Method Parameters

```c#
public int AddTwoNumbers(int a, int b)
```

Returning a Value

- Return type must be specified

```c#
public int AddTwoNumbers(int a, int b)
{
  return a + b;
}
```

- Value must be returned for all possible execution paths

```c#
public int AddTwoNumbers(int a, int b)
{
  if (a > b)
  {
    return a + b;
  }
  // no value returned if we get here, compile time error
}
```

- A Method without Return Value

```c#
public void DisplaySum(int a, int b)
{
  int sum = a + b;
  Console.WriteLine("The sum is " + sum);
}
```

Invoking a Method

- We can pass arguments: values for the parameter(s)

```c#
...

DisplaySum(3,52);

...
```

Flow of Execution

```c#
Console.WriteLine("Before DisplaySum");
DisplaySum(3,5);
Console.WriteLine("After DisplaySum");

public void DisplaySum(int a, int b)
{
  int sum = a + b;
  Console.WriteLine("The sum is " + sum);
}
```

Capturing a Return Value

- Only possible if method isn´t returning void

```c#
DisplaySum(3,52);
int result = AddTwoNumbers(55,44);
```

```c#
int p1 = 3;
int p2 = 52;

DisplaySum(p1, p2);
int result = AddTwoNumbers(55,44);
```

</details>

<!-- #endregion -->

<!-- #region Demo Creating and Using Methods -->

<details>
<summary>Demo Creating and Using Methods</summary>

<br/>

- Creating a method
- Adding parameters
- Return a value
- Invoking the method

Example 1

```c#
int amount = 1234;
int months = 12;

CalculateYearlyWage(amount, months);

Console.ReadLine();

static void CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
{
    Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
}

/*
 * Output:
 * Yearly wage: 14808
 */
```

Example 2

```c#
int amount = 1234;
int months = 12;

int yearlyWage = CalculateYearlyWage(amount, months);

Console.WriteLine($"Yearly wage: {yearlyWage}");

Console.ReadLine();

static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
{
    return monthlyWage * numberOfMonthsWorked;
}

/*
 * Output:
 * Yearly wage: 14808
 */
```

Example 3

```c#
int amount = 1234;
int months = 12;

int yearlyWage = CalculateYearlyWage(amount, months);

Console.WriteLine($"Yearly wage: {yearlyWage}");

Console.ReadLine();

static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
{
    if (numberOfMonthsWorked == 12) // let´s add a bonus month
        return monthlyWage * (numberOfMonthsWorked + 1);

    return monthlyWage * numberOfMonthsWorked;
}

/*
 * Output:
 * Yearly wage: 16042
 */
```

</details>

<!-- #endregion -->

<!-- #region Demo Adding a Helper File -->

<details>
<summary>Demo Adding a Helper File</summary>

<br/>

- Adding a helper file
- Moving the method
- Invoking the method again

Program.cs

```c#
using BethanyPieShopHRM;

int amount = 1234;
int months = 12;

int yearlyWage = Utilities.CalculateYearlyWage(amount, months);

Console.WriteLine($"Yearly wage: {yearlyWage}");

Console.ReadLine();

/*
 * Output:
 * Yearly wage: 16042
 */
```

Utilities.cs

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    internal class Utilities
    {
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            if (numberOfMonthsWorked == 12) // let´s add a bonus month
                return monthlyWage * (numberOfMonthsWorked + 1);

            return monthlyWage * numberOfMonthsWorked;
        }
    }
}
```

</details>

<!-- #endregion -->

<!-- #region Finding the Correct Method -->

<details>
<summary>Finding the Correct Method</summary>

<br/>

Calling the Correct Method

- Method name
- Parameter types and arguments
- Number of parameters

`The combination above must be unique`

Method Overloading

- Matching the Parameters

Program.cs

```c#
DisplaySym(3, 52);
```

Utilities.cs

```c#
public static void DisplaySum (int a, int b)
{
  ...
}

public static void DisplaySum(int a, int b, int c)
{
  ...
}
```

</details>

<!-- #endregion -->

<!-- #region Demo Using Method Overloading -->

<details>
<summary>Demo Using Method Overloading</summary>

<br/>

Program.cs

```c#
using BethanyPieShopHRM;

int amount = 1234;
int months = 12;
int bonus = 1000;

int yearlyWage = Utilities.CalculateYearlyWage(amount, months, bonus);

Console.WriteLine($"Yearly wage: {yearlyWage}");

double amountDouble = 1500.0;
double monthsDouble = 12;
double bonusDouble = 1000;

double yearlyWageWithBonusDouble = Utilities.CalculateYearlyWage(amountDouble, monthsDouble, bonusDouble);

Console.ReadLine();

```

Utilities.cs

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    internal class Utilities
    {
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            if (numberOfMonthsWorked == 12) // let´s add a bonus month
                return monthlyWage * (numberOfMonthsWorked + 1);

            return monthlyWage * numberOfMonthsWorked;
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus)
        {
            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
    }
}

```

</details>

<!-- #endregion -->

<!-- #region Understanding Variable Scope -->

<details>
<summary>Understanding Variable Scope</summary>

<br/>

```c#
public static double SomeMethod()
{
  double value = 0.04;

  ...

  return value;
}
```

```c#
public static double SomeMethod()
{
  double value = 0.04;

  ...

  return value;
}

public static double AnotherMethod()
{
  ...

  return value; // wrong
}
```

</details>

<!-- #endregion -->

<!-- #region Demo Using Variable Scope -->

<details>
<summary>Demo Using Variable Scope</summary>

<br/>

Utilities.cs

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    internal class Utilities
    {
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            int local = 100; // variable scope

            if (numberOfMonthsWorked == 12) // let´s add a bonus month
                return monthlyWage * (numberOfMonthsWorked + 1);

            return monthlyWage * numberOfMonthsWorked;
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            int local = 150; // variable scope

            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus)
        {
            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
    }
}

```

</details>

<!-- #endregion -->

<!-- #region More Options with Methods -->

<details>
<summary>More Options with Methods</summary>

<br/>

Doing More with Methods

- Optional Parameters
- Named arguments
- Expression-bodied syntax

Optional Parameters

- Specify default value for one or more parameters
- Caller can omit the optional ones

Working with Optional Parameters

- Method with optional parameters

```c#
public int AddNumbers
  (int a, int b, int c = 100)
{
  int sum = a + b + c;
  return sum;
}
```

- Calling the method

```c#
AddNumbers(10,20); // no third parameter
AddNumbers(10,20,30);
```

Named arguments

- Not required to follow order of parameters
- One or more parameters can have a name defined when invoking the method

Working with Named Arguments

- Method with parameters

```c#
public static int AddNumbers
  (int a, int b)
  {
    ...
  }
```

- Using named arguments

```c#
AddNumbers(b: 10, a: 20);
```

</details>

<!-- #endregion -->

<!-- #region Demo Using Optional Parameters and Named Arguments -->

<details>
<summary>Demo Using Optional Parameters and Named Arguments</summary>

<br/>

- Using optional parameters

Program.cs

```c#
using BethanyPieShopHRM;

Utilities.UsingOptionalParameters();

Console.ReadLine();

```

Utilities.cs

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    internal class Utilities
    {
        public static void UsingOptionalParameters()
        {
            int monthlyWage1 = 1234;
            int months1 = 12;

            int yearlyWageForEmployee1 = CalculateYearlyWageWithOptional(monthlyWage1,months1);
            Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForEmployee1}");
        }

        public static int CalculateYearlyWageWithOptional(
            int monthlyWage,
            int numberOfMonthsWorked,
            int bonus = 0)
        {
            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
    }
}

```

- Working with named arguments

Program.cs

```c#
using BethanyPieShopHRM;

Utilities.UsingNamedArguments();

Console.ReadLine();

```

Utilities

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    internal class Utilities
    {
        public static void UsingNamedArguments()
        {
            int amount = 1234;
            int months = 12;
            int bonus = 500;

            int yearlyWageForEmployee = CalculateYearlyWageWithNamed(
                bonus: bonus,
                monthlyWage: amount,
                numberOfMonthsWorked: months);

            Console.WriteLine($"Yearly wage for employee (Bethany): {yearlyWageForEmployee}");
        }

        public static int CalculateYearlyWageWithNamed (
            int monthlyWage,
            int numberOfMonthsWorked,
            int bonus)
        {
            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
    }
}

```

</details>

<!-- #endregion -->

<!-- #region Demo Using Expression-bodied Members -->

<details>
<summary>Demo Using Expression-bodied Members</summary>

<br/>

Using expression-bodied syntax

> fat arrow: =>

Program.cs

```c#
using BethanyPieShopHRM;

Utilities.UsingExpressionBodiedSyntax();

Console.ReadLine();
```

Utilities.cs

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    internal class Utilities
    {
        public static void UsingExpressionBodiedSyntax()
        {
            int amount = 1234;
            int months = 12;
            int bonus = 500;

            int yearlyWageForEmployee = CalculateYearlyWageWithExpressionBodied(amount, months, bonus);

            Console.WriteLine($"Yearly wage for employee (Bethany): {yearlyWageForEmployee}");
        }

        public static int CalculateYearlyWageWithExpressionBodied(
            int monthlyWage,
            int numberOfMonthsWorked,
            int bonus) => monthlyWage * numberOfMonthsWorked + bonus;
    }
}

```

</details>

<!-- #endregion -->

<!-- #region Introducing the Main Method -->

<details>
<summary>Introducing the Main Method</summary>

<br/>

Comparing Out 2 Files

- Understanding Top-level statements

Program.cs (current)

```c#
Console.WriteLine("Hello, World!");
```

Utilities.cs

```c#
using System;

namespace ConsoleApp1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello,World!");
    }
  }
}
```

Different Ways to Start the Application

Program.cs (current)

```c#
Console.WriteLine("Hello, World!");
```

Program.cs (pre-C# 10)

```c#
using System;

namespace ConsoleApp1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello,World!");
    }
  }
}
```

The Main Method

- Entry method wich gets called upon start of the app
- Gets created implicitly now
- Implicit since C# 10 & Visual Studio 2022

</details>

<!-- #endregion -->

<!-- #region Demo Exploring the Main Method -->

<details>
<summary>Demo Exploring the Main Method</summary>

<br/>

Exploring the Main method

Program.cs (.NET 5)

```c#
using System;

namespace OlderApp
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello,World!");
    }
  }
}
```

Program.cs (.NET 6)

```c#
Console.WriteLine("Hello,World!");
```

</details>

<!-- #endregion -->

<!-- #region Summary -->

<details>
<summary>Summary</summary>

<br/>

- Methods are used to bring in reuse of code
- Parameters are declared to accept incoming values
- Main method is implicit now

</details>

<!-- #endregion -->

<!-- #endregion -->

<!-- #region Working with Strings -->

## Working with Strings

<!-- #region Introduction -->

<details>
<summary>Introduction</summary>

<br/>

- Working with strings
- Comparing strings
- Parsing from string to other types

</details>

<!-- #endregion -->

<!-- #region Demo A Small Recap on Strings -->

<details>
<summary>Demo A Small Recap on Strings</summary>

<br/>

Program.cs

```c#
using BethanyPieShopHRM;

Utilities.UsingSimpleStrings();

Console.ReadLine();
```

Utilities.cs

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    internal class Utilities
    {
        public static void UsingSimpleStrings()
        {
            string firstName = "Bethany";
            string lastName = "Smith";
            string s;
            s = firstName;
            var userName = "BethanyS";
            userName = userName.ToLower();

            userName = ""; // identical to string.Empty
        }
    }
}
```

</details>

<!-- #endregion -->

<!-- #region Working with Strings -->

<details>
<summary>Working with Strings</summary>

<br/>

| Code                                    | Description                                     |
| :-------------------------------------- | :---------------------------------------------- |
| `int l = myString.Lenght;`              | Get the lenght of the string                    |
| `string upper = myString.ToUpper();`    | Set the string to uppercase                     |
| `string lower = myString.ToLower();`    | Set the string to lowercase                     |
| `bool b = myString.Contains("Hello");`  | Check if a string contains "Hello", return bool |
| `string s = myString.Replace("a","b");` | Replace "a" with "b" in the string              |
| `string sub = myString.Substring(1,3);` | Get a part of the string (zero-based)           |

Concatenating Multiple Strings

```c#
string s1 = "Learning C# "; // notice the extra space at the end
string s2 = "is awesome";
string s3 = s1 + s2;
// Output: "Learning C3 is awesome"
```

Using String.Concat

```c#
string s1 = "Learning C# "; // notice the extra space at the end
string s2 = "is awesome";
string s3 = String.Concat(s1, s2);
```

Less-readable String Concatenation

```c#
string employeeName = "Bethany";
int age = 34;
string greetingText = "Hello " + employeeName + ", your are " + age + " years";
// Output: Hello Bethany, you are 34 years
```

Using string.Format to Concatenate Strings

```c#
string employeeName = "Bethany";
int age = 34;
string greetingText = string.Format("Hello {0}, you are {1} years", employeeName, age);
// Output: Hello Bethany, you are 34 years
```

String Interpolation (Often better and easier to read)

```c#
string employeeName = "Bethany";
int age = 34;
string greetingText = $"Hello {employeeName}, you are {age} years";
// Output: Hello Bethany, you are 34 years
```

</details>

<!-- #endregion -->

<!-- #region Demo Working with Strings -->

<details>
<summary>Demo Working with Strings</summary>

<br/>

- Manipulating strings
- Concatenating strings
- Using string interpolation

Program.cs

```cs
using BethanyPieShopHRM;

Utilities.ManipulatingStrings();

Console.ReadLine();
```

Utilities.cs

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    internal class Utilities
    {
        public static void ManipulatingStrings()
        {
            string firstName = "Bethany";
            string lastName = "Smith";

            string fullName = firstName + " " + lastName;
            string employeeIdentification = String.Concat(firstName,lastName);

            string empId = firstName.ToLower() + "-" + lastName.Trim().ToLower();

            int lenght = empId.Length;

            if (fullName.Contains("beth") || fullName.Contains("Beth"))
            {
                Console.WriteLine("It´s Bethany!");
            }

            string subString = fullName.Substring(1, 3);
            Console.WriteLine("Characters 2 to 4 of fullName are " + subString);

            string userNameWithInterpolation = $"{firstName}-{lastName}";

            /* Output:
             * It´s Bethany!
             * Characters 2 to 4 of fullName are eth
             */
        }
    }
}
```

</details>

<!-- #endregion -->

<!-- #region Using Escape Characters -->

<details>
<summary>Using Escape Characters</summary>

<br/>

Adding Escape Characters

- Always start with a \

```c#
Console.WriteLine("Here are the employee details:\nBethany\tSmith");
```

Representing a File Path

```c#
string escapedFilePath = "C:\\Documents\\readme.txt";
```

Using Verbatim Strings

- Used when text contains \ as part of fhe content
- Improves readability

```c#
string escapedFilePath = "C:\\Documents\\readme.txt";
string verbatimFilePath = @"C:\Documents\readment.txt";
```

</details>

<!-- #endregion -->

<!-- #region Demo Using Escape Characters -->

<details>
<summary>Demo Using Escape Characters</summary>

<br/>

- Escaping text
- Using verbatim strings

</details>

<!-- #endregion -->

<!-- #region Testing Strings for Equality -->

<details>
<summary>Testing Strings for Equality</summary>

<br/>

Comparing Two Strings

```c#
string firstName = "Bethany";
bool b1 = firstName == "Bethany"; // true
bool b2 = firstName == "bethany"; // false
bool b3 = firstName.Equals("Bethany"); // true
```

Comparing Strings Case-Insensitive

```c#
bool b = firstName.ToUpper() == anotherString.ToUpper();
```

</details>

<!-- #endregion -->

<!-- #region Demo Comparing Strings -->

<details>
<summary>Demo Comparing Strings</summary>

<br/>

Comparing Strings

</details>

<!-- #endregion -->

<!-- #region Parsing from String to Other Types -->

<details>
<summary>Parsing from String to Other Types</summary>

<br/>

Use Parsing to Generate a Value from a String

- Can cause issues though

```c#
string w = Console.ReadLine();
double wage = double.Parse(w);

bool active = bool.Parse("true");
```

Using TryParse

- The out keyword will be covered in the next module

```c#
string enteredText = "true";
if (bool.TryParse(enteredText, out bool b))
{
  Console.WriteLine($"The value is {b}");
}
```

</details>

<!-- #endregion -->

<!-- #region Demo Parsing Strings -->

<details>
<summary>Demo Parsing Strings</summary>

<br/>

- Parsing string into other types
- Using `TryParse`

</details>

<!-- #endregion -->

<!-- #region Summary -->

<details>
<summary>Summary</summary>

<br/>

- Strings are a very important concept
- Many methods available
  - Concatenation
  - Parsing

</details>

<!-- #endregion -->

<!-- #endregion -->

<!-- #region Creating Classes and Objects -->

## Creating Classes and Objects

<!-- #region Introduction -->

<details>
<summary>Introduction</summary>

<br/>

- Creating Your First Class and Objects
  - Understanding classes
  - Creating the Employee class
  - Using objects

</details>

<!-- #endregion -->

<!-- #region Understanding Classes and Objects -->

<details>
<summary>Understanding Classes and Objects</summary>

<br/>

### Understanding Classes

<br/>

`With just variables, we only get so far.`

If we want to represent a structure, we need a custom type

Typical models

- Employee
- Customer
- Message
- Transaction

Custom Types

- Class (Most commonly used)
- Struct

<br/>

Classes in C#

- Blueprint of an object
- Defines data and funcionality to work on its data
- Created using class keyword
- Foundation of OO (object-orientation)

In C#, most code will live inside a class

- Program.cs and Utilities class used up until now
- Most code will live inside a class

The Class Template

```c#
public class MyClass
{
  public int a;
  public string b;

  public void MyMethod()
  {
    Console.WriteLine("Hello world");
  }
}
```

Contents of a Class

- Fields
- Properties
- Methods
- Events

<br/>

### Creating the Employee Class

Thinking of an Employee in real life

- Identity: Name
- Attributes: Age, Wage
- Behaviors: Get pai, Perform work

```c#
public class Employee
{
  // class code will come here
}
```

Adding Fields

- Class-level variables
- Contain value

```c#
public class Employee
{
  public string firstName;
  public int age;
}
```

Adding Methods

- Perform actions
- Often change the state

```c#
public class Employee
{
  public string firstName;
  public int age;

  public void PerformWork()
  {
    // method code goes here
  }
}
```

Access Modifiers

- `public` (outside the class)
- `private` (inside the class)
- `protected` (available for the class and its inheritors)

</details>

<!-- #endregion -->

<!-- #endregion -->
