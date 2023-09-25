string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;

for(int i = 0; i < myStrings.Length; i++)
{   
    do{
        periodLocation = myStrings[i].IndexOf('.');
        if (periodLocation > 0) {
             Console.WriteLine(myStrings[i].Remove(periodLocation));
            myStrings[i] = myStrings[i].Substring(periodLocation + 1);
            myStrings[i].TrimStart();
        }
        else{
            Console.WriteLine(myStrings[i]);
        }
      
    } while (periodLocation > 0);
}