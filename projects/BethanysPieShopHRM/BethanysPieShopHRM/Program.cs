using BethanysPieShopHRM.HR;

Employee bethany = new Employee("Bethany","Smith","bethany@snowball.be", new DateTime(1979,1,16),25);
Employee mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965,1,16), 30);
Researcher bobJunior = new JuniorResearcher("Bob","Spencer","bob@snowball.be", new DateTime(1988,1,23),17);

Employee jake = new Employee("Jake","Nicols","jake@snowball.be", new DateTime(1995,8,16),25,"New street","123","123456","Pie Ville");
string streetName = jake.Address.Street;

bethany.DisplayEmployeeDetails();
bethany.PerformWork(8);
bethany.PerformWork();
bethany.PerformWork(3);
bethany.ReceiveWage();

mary.DisplayEmployeeDetails();
mary.PerformWork(25);
mary.PerformWork();
mary.PerformWork();
mary.ReceiveWage();
//mary.AttendManagementMeeting();

bobJunior.ResearchNewPieTastes(5);
bobJunior.ResearchNewPieTastes(5);

/* Output:
 * 
 * First name:     Bethany
 * Last name:      Smith
 * E-mail:                 bethany@snowball.be
 * Birthday:       16/01/1979
 * Tax rate:       0,15
 * Bethany Smith has worked for 8 hour(s)!
 * Bethany Smith has worked for 9 hour(s)!
 * Bethany Smith has worked for 12 hour(s)!
 * Bethany Smith has received a wage of 0 for 12 hour(s) of work.
 * 
 * First name:     Mary
 * Last name:      Jones
 * E-mail:                 mary@snowball.be
 * Birthday:       16/01/1965
 * Tax rate:       0,15
 * Mary Jones has worked for 25 hour(s)!
 * Mary Jones has worked for 26 hour(s)!
 * Mary Jones has worked for 27 hour(s)!
 * Mary Jones has received a wage of 0 for 27 hour(s) of work.
 * Manager Mary Jones is now attending a long meeting tha could have been an email!
 * 
 * Researcher Bob Spencer is working still on a new pie taste!
 * Researcher Bob Spencer has invented a new pie taste! Total number of pies invented: 1
 */