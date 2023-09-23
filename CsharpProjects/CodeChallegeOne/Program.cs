string? userInput = "";
int inputToInt = 0;
bool isValidInput = true;

Console.WriteLine("Enter an integer value between 5 and 10");

do {
    userInput = Console.ReadLine();

    isValidInput = int.TryParse(userInput, out inputToInt);
    if(!isValidInput)
         Console.WriteLine("Sorry, you entered an invalid number, please try again");
    else if(!(inputToInt >=5 && inputToInt <= 10))
        Console.WriteLine($"You entered {inputToInt}. Please enter a number between 5 and 10.");
    else
        break;

} while(true);

Console.WriteLine($"Your input value ({inputToInt}) has been accepted.");