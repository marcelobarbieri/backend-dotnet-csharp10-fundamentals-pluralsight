int intMaxValue = int.MaxValue; // 2147483647
int intMinValue = int.MinValue; //-2147483648

char userSelection = 'a';
char upperVersion = char.ToUpper(userSelection); // 65 'A'

bool isDigit = char.IsDigit(userSelection); // false
bool isLetter = char.IsLetter(userSelection); // true

Console.ReadLine();