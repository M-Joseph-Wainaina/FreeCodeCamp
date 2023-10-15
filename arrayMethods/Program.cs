using CustomTypes;

string[] pallets = { "B14", "A11", "a11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}



// myType[] myTypeArray = new myType[3];

// myTypeArray[0] = new myType();
// myTypeArray[0].num = 1;
// myTypeArray[1] = new myType();
// myTypeArray[2] = new myType();

// Array.Resize<myType>(ref myTypeArray, 6);
// Console.WriteLine($"{myTypeArray.Count()} { myTypeArray[0].num}");
// Console.WriteLine("a" + "b" + 1 + 2);
Console.WriteLine("After removing empty ...");
var nonEmpty = pallets.Where(pallet => pallet != null ).ToArray();
foreach(var item in nonEmpty)
{
    Console.WriteLine(item);
}