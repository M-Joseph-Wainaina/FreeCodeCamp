string[] values = { "12.3", "45", "ABC", "11", "DEF" };

string message = "";
decimal sum = 0.0m;
decimal num = 0.0m;
bool isNum = false;

Array.ForEach(values, value => {
    isNum = decimal.TryParse(value, out num);
    _ = isNum ?
    (sum += num).ToString()
    :
    message += value;
});

var numbers = values.Where
    (
        x => decimal.TryParse(x, out _)
    ).ToList();
var notNumbers = values.Where
    (
        x => !decimal.TryParse(x, out _)
    ).ToList();

Console.WriteLine($"Message: {message}\nTotal: {notNumbers[1]}");