string[] OrderIDs =
{
    "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"
};

foreach (string Id in OrderIDs)
{
    if (!Id.StartsWith("B"))
    {
        continue;
    }
    Console.WriteLine(Id);
}


// fraudulentOrderIDs[0] = "F000";

// int sum = 0;
// int[] inventory = { 200, 450, 700, 175, 250 };
// int bin = 0;
// foreach (int items in inventory)
// {
//     bin++;

//     sum += items; 
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }

// // Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// // Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// // Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
// Console.WriteLine($"We have {sum} items in inventory.");