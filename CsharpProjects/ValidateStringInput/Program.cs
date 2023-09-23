using System;
var roles = new List<string> {"administrator", "manager", "user"};

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

bool isInValid = false;

do{
    string? userInput = Console.ReadLine();
    
    if(userInput != null)
    {
        userInput = userInput.Trim();
        userInput = userInput.ToLower();

        isInValid = roles.Contains(userInput);

        string message = roles.Contains(userInput) ?      
            $"Your input value ({userInput}) has been accepted."   
            :
            $"The role name that you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager, or User)"
            ;
        Console.WriteLine(message);
    } 

} while(!isInValid);
