using BethanysPieShopHRM.Logic;
using Newtonsoft.Json;

namespace BethanysPieShopHRM.HR
{
    internal class Employee: IEmployee
    {
        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double? hourlyRate;

        private DateTime birthDay;
        private const int minimalHoursWorkedUnit = 1;

        private Address address;

        private static double taxRate = 0.15;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int NumberOfHoursWorked
        {
            get { return numberOfHoursWorked; }
            protected set { numberOfHoursWorked = value; }
        }

        public double Wage
        {
            get { return wage; }
            private set { wage = value; }
        }

        public double? HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                if (hourlyRate < 0) // this should always be higher than 0
                    hourlyRate = 0;
                else
                    hourlyRate = value;
            }
        }

        public DateTime BirthDay
        {
            get { return birthDay; }
            set
            {
                birthDay = value;
            }
        }

        public Address Address
        {
            get { return address;  }
            set
            {
                address = value;
            }
        }

        public Employee(string firstName, string lastName, string email, DateTime birthDay) 
            : this(firstName, lastName, email, birthDay, 0)
        { }

        public Employee(
            string firstName, 
            string lastName, 
            string email, 
            DateTime birthDay, 
            double? hourlyRate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            HourlyRate = hourlyRate ?? 10;
        }

        public Employee(
            string firstName,
            string lastName,
            string email,
            DateTime birthDay,
            double? hourlyRate,
            string street,
            string houseNumber,
            string zip,
            string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            HourlyRate = hourlyRate ?? 10;

            Address = new Address(street, houseNumber, zip, city);
        }

        public void PerformWork()
        {
            //numberOfHoursWorked++;
            PerformWork(minimalHoursWorkedUnit);
            //Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
        }

        public void PerformWork(int numberOfHours)
        {
            NumberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{FirstName} {LastName} has worked for {numberOfHoursWorked} hour(s)!");
        }

        public double ReceiveWage(bool resetHours = true)
        {
            double wageBeforeTax = 0.0;
            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{FirstName} {LastName} has received a wage of {Wage} for {numberOfHoursWorked} hour(s) of work.");

            if (resetHours)
                NumberOfHoursWorked = 0;

            return Wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{FirstName}\nLast name: \t{LastName}\nE-mail: \t\t{Email}\nBirthday: \t{BirthDay.ToShortDateString()}\nTax rate: \t{taxRate}");
        }

        public int CalculateBonus (int bonus)
        {
            if (NumberOfHoursWorked > 10)
                bonus *= 2;

            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;
        }

        public int CalculatedBonusAndBonusTax(int bonus, ref int bonusTax)
        {
            if (NumberOfHoursWorked > 10)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");
            return bonus;
        }

        public int CalculatedBonusAndBonusTaxOut(int bonus, out int bonusTax)
        {
            bonusTax = 0;
            if (NumberOfHoursWorked > 10)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");
            return bonus;
        }

        public static void UsingACustomType()
        {
            List<string> list = new List<string>();
        }

        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }

        public static void DisplayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
        }

        public double CalculateWage()
        {
            WageCalculations wageCalculations = new WageCalculations();
            double calculateValue = wageCalculations.ComplexWageCalculation(Wage, taxRate, 3, 42);
            return calculateValue;
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName} {LastName} received a generic bonus of 100!");
        }

        public void GiveCompliment()
        {
            Console.WriteLine($"Youpve done a great job, {FirstName}");
        }
    }
}
