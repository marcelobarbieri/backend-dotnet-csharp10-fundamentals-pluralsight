namespace BethanysPieShopHRM.HR
{
    internal class Manager : Employee
    {
        public Manager(
            string firstName, string lastName, string email, DateTime birthDay, double? hourlyRate) 
            : base(firstName, lastName, email, birthDay, hourlyRate)
        {
        }

        public void AttendManagementMeeting()
        {
            NumberOfHoursWorked += 10;
            Console.WriteLine($"Manager {FirstName} {LastName} is now attending a long meeting tha could have been an email!");
        }
    }
}
