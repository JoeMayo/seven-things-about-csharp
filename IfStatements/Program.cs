// Conditional Expressions

bool isDoorOne;
bool isDoorTwo = true;

string userResponse = "Q";
bool isQuit = userResponse == "Q";

bool isNotNumbered = userResponse != "1" && userResponse != "2";
bool isUpperOrLowerQ = userResponse == "q" || userResponse == "Q";

// Simple if - true condition

if (userResponse == "q" || userResponse == "Q")
{
  Console.WriteLine("User wants to quit.");
}

if (userResponse != "q" && userResponse != "Q")
{
  Console.WriteLine("User doesn't want to quit.");
}

// Checking for true or false

if (userResponse == "q" || userResponse == "Q")
{
  Console.WriteLine("User wants to quit.");
}
else
{
  Console.WriteLine("User doesn't want to quit.");
}

// Checking multiple conditions

if (userResponse == "1")
{
  Console.WriteLine("User picked Door #1.");
}
else if (userResponse == "2")
{
  Console.WriteLine("User picked Door #2.");
}
else if (userResponse == "q" || userResponse == "Q")
{
  Console.WriteLine("User wants to quit.");
}
else
{
  Console.WriteLine("Please select 1, 2, or 3!");
}

// Simplifying conditional logic

bool userWantsToQuit = userResponse == "q" || userResponse == "Q";

if (userWantsToQuit)
{
  Console.WriteLine("User wants to quit.");
}

// Simplifying conditional assignment

string userChoice;

if (userWantsToQuit)
  userChoice = "Quit";
else
  userChoice = "Continue";

string userAction = userWantsToQuit ? "Quit" : "Continue";