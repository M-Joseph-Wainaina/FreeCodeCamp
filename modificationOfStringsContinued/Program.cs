// string message = "(What if) i am only (only interested) in the (last set of parenthesis)?";

//int openingPosition = message.LastIndexOf('(');
// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string edited  = message;

// while(true)
// {
//     int startingPosition = edited.IndexOf('(');
//     int lastPosition = edited.IndexOf(')');

//     startingPosition += 1;
//     int length = lastPosition - startingPosition;
//     if(lastPosition  == -1 || startingPosition == -1)
//     {
//         break;
//     }
//     Console.WriteLine(edited.Substring(startingPosition, length));
//     edited = edited.Substring(lastPosition += 1);
// } 

// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS Message: {message}");
// char[] openSymbols = { '[', '{', '(' };
// int startPosition = 6;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition: {message.Substring(openingPosition)}");

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

char[] openSymbols = {'(', '[', '{'};
int startingPosition = 0;
int closingPosition = 0;

while(true)
{
    startingPosition = message.IndexOfAny(openSymbols);

    if (startingPosition == -1) break;

    switch (message[startingPosition])
    {
        case '(':
            closingPosition = message.IndexOf(')');
            break;
        case '{':
            closingPosition = message.IndexOf('}');
            break;
        case '[':
            closingPosition = message.IndexOf(']');
            break;
    }
    startingPosition++;
    int length = closingPosition - startingPosition;
    Console.WriteLine(message.Substring(startingPosition, length));
    message = message.Substring(closingPosition);
}