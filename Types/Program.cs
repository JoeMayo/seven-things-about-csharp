
bool isCSharpCool = true;

long customerID = default;
double pi = default;
bool isArchived = default;
char middleInitial = default;
string city = default;

Console.WriteLine("\nDefault Values:\n");
Console.WriteLine(
    "Customer ID: {0}\n" +
    "PI:        : {1}\n" +
    "Is Arhived : {2}\n" +
    "Initial    : {3}\n" +
    "City       : {4}\n",
    customerID, pi, isArchived, 
    middleInitial == '\u0000' ? "\\u0000" : middleInitial, 
    city == null ? "null" : city);

Console.WriteLine("\nArrays:\n");

decimal[] employeePayroll = new decimal[10];
employeePayroll[0] = 1375.91m;
employeePayroll[1] = 957.32m;

Console.WriteLine(
    "First Employee Pay: ${0}\n" +
    "Second Employee Pay: ${1}\n",
    employeePayroll[0],
    employeePayroll[1]);


string[] customerEmailAddresses = 
    new string[] 
    { 
        "a@acme.com", 
        "b@example.com", 
        "c@inter.net"
    };

foreach (string address in customerEmailAddresses)
{
    Console.WriteLine("Email sent to " + address);
}

for (int i = 0; i < customerEmailAddresses.Length; i++)
{
    Console.WriteLine(
        "Email sent to " + customerEmailAddresses[i]);
}

Console.WriteLine("\nNumeric Literals:\n");

int lineFeedDecimal = 10;
byte lineFeedHex = 0x0a;
short lineFeedBinary = 0b1010;
char lineFeedChar = '\u000A';

Console.WriteLine(
    "Decimal: " + lineFeedDecimal + 
    "\nHex: " + lineFeedHex + 
    "\nBinary: " + lineFeedBinary +
    "\nChar: '" + lineFeedChar + "'");

byte byteMax = 0b_1111_1111;
Console.WriteLine("Byte Max: " + byteMax);

Console.WriteLine("\nConversions:\n");

byte ageByte = 18;
short ageShort = ageByte;
int ageInt = ageShort;
long ageLong = ageInt;

Console.WriteLine("Long: " + ageLong);

// causes a compiler error
// byte ageNextBirthday = ageByte + 1;

byte ageNextBirthday = (byte)(ageByte + 1);

Console.WriteLine("Next Birthday: " + ageNextBirthday);

ageNextBirthday = Convert.ToByte(ageByte + 1);

Console.WriteLine("Next Birthday: " + ageNextBirthday);

Console.WriteLine("Next Birthday: " + ageNextBirthday.ToString());

Console.WriteLine("\nAdding numbers...\n");

Console.Write("First Number: ");
string firstInput = Console.ReadLine();

int firstNumber = int.Parse(firstInput);

Console.Write("Second Number: ");
string secondInput = Console.ReadLine();

int secondNumber = int.Parse(secondInput);

int sum = firstNumber + secondNumber;

Console.WriteLine("Sum: " + sum);

bool isParseOk = int.TryParse(secondInput, out int tryNumber);

if (isParseOk)
    Console.WriteLine("TryParse: " + tryNumber);