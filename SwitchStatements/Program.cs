// 1 - Switch statements are like if/else

Console.Write("Which door? (1, 2, or 3): ");
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
  // 2 - The default case is often useful
  default:
    Console.Write("Sorry, door #" + doorResponse + " doesn't exist.");
    // 3 - Fall through is explicit
    break;
}

//4 - Cases can group

Console.Write("Moving weight in 1000/lb? (1 through 10): ");
string weightString = Console.ReadLine();

int.TryParse(weightString, out int weight);

switch (weight)
{
    case 1:
    case 2:
    case 3:
        Console.WriteLine("Price is $2,500.");
        break;
    case 4: 
    case 5:
    case 6:
        Console.WriteLine("Price is $5,000");
        break;
    case 7: 
    case 8:
    case 9:
    case 10:
        Console.WriteLine("Price is $7,500");
        break;
    default:
        Console.WriteLine("Price is $10,000");
        break;
}

// 5 - Cases can be ints, enums, or strings

CustomerType hotelCustomer = CustomerType.Silver;

switch (hotelCustomer)
{
    case CustomerType.Bronze:
        Console.WriteLine("Welcome back to our hotel!");
        break;
    case CustomerType.Silver:
        Console.WriteLine("Here's a free bottle of water!");
        break;
    case CustomerType.Gold:
        Console.WriteLine("We've upgraded your room!");
        break;
    default:
        Console.WriteLine("Would you like to sign-up for our loyalty program?");
        break;
}

// 6 - When to use if vs switch

if (weight > 0 && weight <= 3)
    Console.WriteLine("Price is $2,500.");
else if (weight >= 4 && weight <= 6)
    Console.WriteLine("Price is $5,000");
else if (weight >= 7 && weight <= 10)
    Console.WriteLine("Price is $7,000");
else if (weight >= 11)
    Console.WriteLine("Price is $10,000");
else
    Console.WriteLine("Weight must be 1 or higher.");

// 7 - There's a thing called switch expressions

string loyaltyReward =
    hotelCustomer switch
    {
        CustomerType.Bronze => "Greeting",
        CustomerType.Silver => "Water",
        CustomerType.Gold => "Room Upgrade",
        _ => "Upsell"
    };

Console.WriteLine("Loyalty Reward: " + loyaltyReward);

enum CustomerType
{
    Bronze,
    Silver,
    Gold
}
