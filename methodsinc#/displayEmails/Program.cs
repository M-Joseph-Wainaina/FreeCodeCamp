string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

// string externalDomain = "hayworth.com";

void DisplayInternalEmails()
{

    for (int i = 0; i < corporate.GetLength(0); i++) 
    {
        string firstTwoChars = corporate[i, 0].Substring(0, 2);
        string userName = firstTwoChars.ToLower() + corporate[i, 1].ToLower() + "@contoso.com";
        Console.WriteLine(userName);
    }
}
void DisplayExternalEmails(string externalDomain = "hayworth.com")
{
    for (int i = 0; i < external.GetLength(0); i++) 
    {
        string firstTwoChars = external[i, 0].Substring(0, 2);
        string userName = firstTwoChars.ToLower() + external[i, 1].ToLower() + '@' + externalDomain.ToLower();
        Console.WriteLine(userName);
    }
    
}

DisplayInternalEmails();
DisplayExternalEmails();
