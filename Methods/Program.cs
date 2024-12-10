string street = "";
string city = "";
string state = "";
string zip = "";

Console.Write(@"What is your street address?: ");
street = Console.ReadLine();

ShowAddress();

Console.Write(@"What is your city?: ");
city = Console.ReadLine();

ShowAddress();

Console.Write(@"What is your state?: ");
state = Console.ReadLine();

ShowAddress();

Console.Write(@"What is your zip?: ");
zip = Console.ReadLine();

//
// 1 - Methods have a basic structure
//

ShowAddress();

void ShowAddress()
{
    Console.WriteLine($"Address: {street}, {city}, {state}, {zip}");
}

//
// 2 - Methods can return references and values
//

string formattedAddress = FormatAddress();
Console.WriteLine(formattedAddress);

string FormatAddress()
{
    return 
$@"""
{street}, 
{city}, {state}, {zip}
""";
}

//
// 3 - Methods can accept arguments
//

ShowAddressWithParams(street, city, state, zip);

void ShowAddressWithParams(string streetIn, string cityIn, string stateIn, string zipIn)
{
    Console.WriteLine($"Address: {streetIn}, {cityIn}, {stateIn}, {zipIn}");
}

//
// 4 - Method parameters can be optional
//

ShowFormattedAddress(street, city, state, zip);

Console.Write(@"What is your street2 address?: ");
string street2 = Console.ReadLine();

ShowFormattedAddress(street, city, state, zip, street2);

ShowFormattedAddress(street, street2In: street2, cityIn: city, stateIn: state, zipIn: zip);

void ShowFormattedAddress(string street1In, string cityIn, string stateIn, string zipIn, string street2In = null)
{
    string address = $"{street}\n";

    if (street2In != null)
        address += $"{street2In}\n";

    address += $"{city}, {state}, {zip}";

    Console.WriteLine(address);
}

//
// 5 - You can pass a variable number of parameters
//

ShowVariableAddress(street, city, state, zip);
ShowVariableAddress(street, street2, city, state, zip);

void ShowVariableAddress(params string[] items)
{ 
    Console.WriteLine($"\nAddress:\n");
    for (int i = 0; i < items.Count(); i++)
        Console.WriteLine(items[i]);
}

//
// 6 - Single-line methods can be simplified
//

ShowOneLineAddress();

void ShowOneLineAddress() => Console.WriteLine($"Address: {street}, {city}, {state}, {zip}");

//
// 7 - Methods can nest methods
//

ShowCleanedAddress(street, city, state, zip);

void ShowCleanedAddress(string streetIn, string cityIn, string stateIn, string zipIn)
{
    Console.WriteLine(
        $"Address: " +
        $"{streetIn.Trim().Trim(',').Trim()}, " +
        $"{cityIn.Trim().Trim(',').Trim()}, " +
        $"{stateIn.Trim().Trim(',').Trim()}, " +
        $"{zipIn.Trim().Trim(',').Trim()}");
}

ShowCleanedAddressLocal(street, city, state, zip);

void ShowCleanedAddressLocal(string streetIn, string cityIn, string stateIn, string zipIn)
{
    Console.WriteLine(
        $"Address: " +
        $"{Clean(streetIn)}, " +
        $"{Clean(cityIn)}, " +
        $"{Clean(stateIn)}, " +
        $"{Clean(zipIn)}");
    
    string Clean(string element) => element.Trim().Trim(',').Trim();
}