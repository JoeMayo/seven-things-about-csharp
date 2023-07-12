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


// Sound - Not supported on macOS

Console.Beep();

Console.Beep(400, 50);
Console.Beep(700, 100);

// Twinkle Twinkle Little Star
// - by James Curran
// https://medium.com/p/8dbcf0d77c4f

const float C = 261.63f;
const float Csharp = 277.18f;
const float D = 293.66f;
const float Dsharp = 311.13f;
const float E = 329.63f;
const float F = 349.23f;
const float Fsharp = 369.99f;
const float G = 392.00f;
const float Gsharp = 415.30f;
const float A = 440.00f;
const float Asharp = 466.16f;
const float B = 493.88f;

int Octave3(float note) => (int)(note / 2);
int Octave2(float note) => (int)(note / 4);
int Octave1(float note) => (int)(note / 8);
int Octave0(float note) => (int)(note / 16);
int Octave4(float note) => (int)note;
int Octave5(float note) => (int)note * 2;
int Octave6(float note) => (int)note * 4;
int Octave7(float note) => (int)note * 8;

const int n16 = 100; // change this to adjust note length
const int n8 = n16 * 2;
const int n4 = n16 * 4;
const int n2 = n16 * 8;
const int n1 = n16 * 16;
const int eighth = n8;
const int quarter = n4;
const int half = n2;
const int whole = n1;

Console.Beep(Octave4(C), quarter);
Console.Beep(Octave4(C), quarter);
Console.Beep(Octave4(G), quarter);
Console.Beep(Octave4(G), quarter);
Console.Beep(Octave4(A), quarter);
Console.Beep(Octave4(A), quarter);
Console.Beep(Octave4(G), half);
Console.Beep(Octave4(F), quarter);
Console.Beep(Octave4(F), quarter);
Console.Beep(Octave4(E), quarter);
Console.Beep(Octave4(E), quarter);
Console.Beep(Octave4(D), quarter);
Console.Beep(Octave4(D), quarter);
Console.Beep(Octave4(C), half);
Console.Beep(Octave4(G), quarter);
Console.Beep(Octave4(G), quarter);
Console.Beep(Octave4(F), quarter);
Console.Beep(Octave4(F), quarter);
Console.Beep(Octave4(E), quarter);
Console.Beep(Octave4(E), quarter);
Console.Beep(Octave4(D), half);
Console.Beep(Octave4(G), quarter);
Console.Beep(Octave4(G), quarter);
Console.Beep(Octave4(F), quarter);
Console.Beep(Octave4(F), quarter);
Console.Beep(Octave4(E), quarter);
Console.Beep(Octave4(E), quarter);
Console.Beep(Octave4(D), half);
Console.Beep(Octave4(C), quarter);
Console.Beep(Octave4(C), quarter);
Console.Beep(Octave4(G), quarter);
Console.Beep(Octave4(G), quarter);
Console.Beep(Octave4(A), quarter);
Console.Beep(Octave4(A), quarter);
Console.Beep(Octave4(G), half);
Console.Beep(Octave4(F), quarter);
Console.Beep(Octave4(F), quarter);
Console.Beep(Octave4(E), quarter);
Console.Beep(Octave4(E), quarter);
Console.Beep(Octave4(D), quarter);
Console.Beep(Octave4(D), quarter);
Console.Beep(Octave4(C), half);