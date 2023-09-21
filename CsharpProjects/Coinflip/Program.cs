
var flip = new Random();
int value = flip.Next(1, 3);
Console.WriteLine(value);

var result = value >= 1 ? "Heads" : "Tails";

Console.WriteLine(result);
