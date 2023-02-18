using System.Text;

string firstName = "Bethany";
string lastName = "Smith";

StringBuilder builder = new StringBuilder();
builder.Append("Last name: ");
builder.AppendLine(lastName);
builder.Append("First name: ");
builder.AppendLine(firstName);
string result = builder.ToString();