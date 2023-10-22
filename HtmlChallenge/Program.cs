const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

string[] openingTags = {"<span>", "<div>"};

foreach(var openingTag in openingTags)
{
    string closingTag = "";
    int closingIndex = 0;
    int startIndex = input.IndexOf(openingTag);
    int length = 0;

    switch (openingTag)
    {
        case "<span>":
            closingTag = "</span>";
            closingIndex = input.IndexOf(closingTag);
            startIndex += openingTag.Length;
            length = closingIndex - startIndex;
            quantity = input.Substring(startIndex, length);
            break;

        case "<div>":
            closingTag = "</div>";
            closingIndex = input.IndexOf(closingTag);
            startIndex += openingTag.Length;
            length = closingIndex - startIndex;
            output = input.Substring(startIndex, length);
            break;

    }
    
}
Console.WriteLine("Quantity: " + quantity);
Console.WriteLine("Output: " + output.Replace("trade", "reg"));