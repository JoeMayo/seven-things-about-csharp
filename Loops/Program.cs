// While loops

string choice = "";

// while (choice != "Q" && choice != "q")
// {
//   Console.WriteLine("\nDoor Chooser\n");
//   Console.WriteLine("1 - Door 1");
//   Console.WriteLine("2 - Door 2");
//   Console.WriteLine("Q - Quit\n");

//   Console.Write("Please choose (1, 2, or Q): ");

//   choice = Console.ReadLine();

//   Console.WriteLine("\n* You chose '{0}'", choice);
// }

// do/while loops

do
{
  Console.WriteLine("\nDoor Chooser\n");
  Console.WriteLine("1 - Door 1");
  Console.WriteLine("2 - Door 2");
  Console.WriteLine("Q - Quit\n");

  Console.Write("Please choose (1, 2, or Q): ");

  choice = Console.ReadLine();

  Console.WriteLine("\n* You chose '{0}'", choice);
}
while (choice != "Q" && choice != "q");

// foreach loop

Console.Write("What is your password? ");
string password = Console.ReadLine();

bool hasUpper = false;
bool hasLower = false;
bool hasNumeric = false;
bool hasNonAlphaNumeric = false;

foreach (char ch in password)
{
  if (char.IsUpper(ch))
  {
    hasUpper = true;
  }
  else if (char.IsLower(ch))
  {
    hasLower = true;
  }
  else if (char.IsDigit(ch))
  {
    hasNumeric = true;
  }
  else
  {
    hasNonAlphaNumeric = true;
  }
}

bool isValidPassword = hasUpper && hasLower && hasNumeric && hasNonAlphaNumeric;
string isOrIsNot = isValidPassword ? "is" : "is not";

Console.WriteLine("Password " + isOrIsNot + " valid.");

// for loop

const int PinSize = 4;
const int ZeroToNine = 10;

string pin = "";

for (int i=0; i < PinSize; i++)
{
  int randNum = Random.Shared.Next(ZeroToNine);
  pin = pin + randNum;
}

Console.WriteLine("Your new pin: " + pin);

// break statement

hasUpper = false;
hasLower = false;
hasNumeric = false;
hasNonAlphaNumeric = false;

int iterationCount = 0;

foreach (char ch in password)
{
  iterationCount++;

  if (char.IsUpper(ch))
    hasUpper = true;
  else if (char.IsLower(ch))
    hasLower = true;
  else if (char.IsDigit(ch))
    hasNumeric = true;
  else
    hasNonAlphaNumeric = true;

  if (hasUpper && hasLower && hasNumeric && hasNonAlphaNumeric)
    break;
}

Console.WriteLine("Number of characters: {0}", password.Length);
Console.WriteLine("Number of iterations: {0}", iterationCount);

// continue statement

Console.Write("What is your name? ");
string name = Console.ReadLine();

string userName = "";

foreach (char ch in name)
{
  if (ch != ' ')
  {
    userName = userName + ch;
  }
}

Console.WriteLine("Your new email address is '{0}.example.com'", userName);

userName = "";

foreach (char ch in name)
{
  if (ch == ' ')
    continue;

  userName = userName + ch;
}

Console.WriteLine("Your new email address is '{0}.example.com'", userName);