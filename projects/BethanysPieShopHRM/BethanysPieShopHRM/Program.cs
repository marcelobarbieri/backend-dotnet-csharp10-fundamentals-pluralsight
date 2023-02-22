using BethanysPieShopHRM.HR;

// Employee mysteryEmployee = null;
// mysteryEmployee.DisplayEmployeeDetails();

/* Output:
 * 
 * System.NullReferenceException: 'Object reference not set to an instance of an object.'
 * mysteryEmployee was null.
 */

Employee bethany = new Employee(
    "Bethany",
    "Smith",
    "bethany@snowball.be", 
    new DateTime(1979,1,16),
    null,
    EmployeeType.Manager);