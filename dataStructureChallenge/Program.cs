string[] values = {"12.3", "45", "ABC", "11", "DEF" };

string message = "";
decimal sum = 0.0m;
decimal num = 0.0m;
bool isNum = false;

Array.ForEach(values, (var value)  => {
    isNum = decimal.TryParse(value, out num);
    _ = isNum ? (sum += num).ToString() : message += value;
});


Console.WriteLine($"Message: {message}\nTotal: {sum}");