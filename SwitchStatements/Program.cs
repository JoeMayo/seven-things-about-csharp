// 1 - Switch statements are like if/else

Console.Write("Which door (1, 2, or 3): ");
string doorResponse = Console.ReadLine();

switch (doorResponse)
{
  case "1":
    Console.Write("You chose the first door.");
    break;
  case "2":
    Console.Write("You chose the middle door.");
    break;
  case "3":
    Console.Write("You chose the last door.");
    break;
  default:
    Console.Write("Sorry, door #" + doorResponse + " doesn't exist.");
    break;
}

// 2 - Cases can be int too

int.TryParse(doorResponse, out int doorNumber);

