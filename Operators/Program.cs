Console.WriteLine("\nAlgebraic Operators:\n");

float result = 1 + 3 * 4;
Console.WriteLine("1 + 3 * 4 == " + result);

result = (1 + 3) * 4;
Console.WriteLine("(1 + 3) * 4 == " + result);

Console.WriteLine("\nConditional Side-Effects:\n");

bool internalCondition;
bool EvalCondition()
{
  Console.WriteLine("EvalCondition Running...");
  internalCondition = true;
  return internalCondition;
}

bool orCondition = true;

if (orCondition || EvalCondition())
  Console.WriteLine("One of these are true.");
else
  Console.WriteLine("Neither of these are true.");

bool andCondition = false;

if (andCondition && EvalCondition())
  Console.WriteLine("Both of these are true.");
else
  Console.WriteLine("One of these are false.");

Console.WriteLine("\nNull References:\n");

string person = default;

// This throws NullReferenceException
// int nameLength = person.Length

int nameLength = person?.Length ?? 0;

Console.WriteLine("\nBinary Operators\n");

int ten = 0b00001010;

Console.WriteLine(
  Convert.ToString(ten, 2).PadLeft(8, '0') +
  " is " + ten);

int twenty = ten << 1;

Console.WriteLine(
  Convert.ToString(twenty, 2).PadLeft(8, '0') +
  " is " + twenty);

byte addressSegment = 0b11101010;
byte subnetMask = 0b00011111;

byte maskedAddress = (byte)(addressSegment & subnetMask);

Console.WriteLine(
  "\nMaskedAddress: " +
  Convert.ToString(twenty, 2).PadLeft(8, '0'));

Console.WriteLine("\nCompound Operators\n");

int count = 0;

count = count + 1;

count += 1;

count++;

Console.WriteLine("\nTernary Operators\n");

string countType;

if (count % 2 == 0)
{
  countType = "even";
}
else
{
  countType = "odd";
}

if (count % 2 == 0)
  countType = "even";
else
  countType = "odd";

countType = count % 2 == 0 ? "even" : "odd";

Console.WriteLine("Count is " + countType);

Console.WriteLine("Count is " + (count % 2 == 0 ? "even" : "odd"));

Console.WriteLine("\nThe Math Class\n");

double countCubed = Math.Pow(count, 3);

Console.WriteLine("Count Cubed: " + countCubed);

Console.WriteLine("E: " + Math.E);
Console.WriteLine("PI: " + Math.PI);
Console.WriteLine("Tau: " + Math.Tau);

double ePI = Math.Exp(Math.PI);
Console.WriteLine("E^PI: " + ePI);

double max = Math.Max(countCubed, ePI);

Console.WriteLine("Max: " + max);