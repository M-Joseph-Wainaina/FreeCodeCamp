Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        int target = random.Next(1, 7);
        int roll = random.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine($"You {WinOrLose(roll, target)}!");
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    
    string? userInput = Console.ReadLine();
    
    return userInput.ToLower() == "y" ? true : false; 
}

string WinOrLose(int roll, int target)
{
    return roll > target ? "Win" : "Lose";   
}