Console.WriteLine("Console I/O Demo\n");

Console.WriteLine("\t 1. Door #1");
Console.WriteLine("\t 2. Door #2");
Console.WriteLine("\t Q. Quit");

Console.Write("\nYour Choice (1, 2, or Q): ");

string doorChoice = Console.ReadLine();

Console.WriteLine("\nYou chose \"" + doorChoice + "\"");

Console.Write("Try pressing any key: ");

ConsoleKeyInfo oneKey = Console.ReadKey();

System.Console.WriteLine();
Console.WriteLine("Key: {0}", oneKey.KeyChar);

Console.WriteLine("Alt: {0}", oneKey.Modifiers == ConsoleModifiers.Alt);
Console.WriteLine("Control: {0}", oneKey.Modifiers == ConsoleModifiers.Control);
Console.WriteLine("Shift: {0}", oneKey.Modifiers == ConsoleModifiers.Shift);
Console.WriteLine("Enter: {0}", oneKey.Key == ConsoleKey.Enter);

Console.WriteLine();

Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.DarkBlue;

Console.WriteLine(
  "The background color is {0} and the foreground color is {1}",
  Console.BackgroundColor,
  Console.ForegroundColor);

Console.Title = "Console I/O Demo";

// Console.Beep();

// Console.Beep(400, 50);
// Console.Beep(700, 100);