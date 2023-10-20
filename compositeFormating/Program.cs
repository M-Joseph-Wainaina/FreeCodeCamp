// string first = "Hello";
// string second = "World";

// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);
// //formatting currency
// decimal price = 123.45m;
// int discount = 50;

// Console.WriteLine($"Price {price:C} (save {discount:C})");

//formatting numbers
decimal measurement = 121345678.91234m;
Console.WriteLine($"Measurements: {measurement:N2} units");

decimal tax = .1234m;
Console.WriteLine($"Tax rate: {tax :P2}");