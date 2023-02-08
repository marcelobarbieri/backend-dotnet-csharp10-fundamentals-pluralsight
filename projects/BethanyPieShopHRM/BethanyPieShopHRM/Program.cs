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