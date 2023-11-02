// int[] schedule = {800, 1200, 1600, 2000};

// void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT) 
// {
//     int diff = 0;
//     if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//     {
//         Console.WriteLine("Invalid GMT");
//     }
//     else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
//     {
//         diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     } 
//     else 
//     {a
//         diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     }

//     for (int i = 0; i < times.Length; i++) 
//     {
//         int newTime = ((times[i] + diff)) % 2400;
//         Console.WriteLine($"{times[i]} -> {newTime}");
//     }
// }
// DisplayAdjustedTimes(schedule, 6, -6);

// int age = 100;
// string[] names = {"Jose", "Wainaina"};

// void UpdateInfo(int age, string[] names)
// {
//     age = 50;
//     names[0] = "Joseph";
// }

// UpdateInfo(age, names);

// Console.WriteLine($"Updated age {age}\nupdated names {names[0]} {names[1]}");

string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(status, true);
Console.WriteLine($"End: {status}");

void SetHealth(string status, bool isHealthy) 
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}
