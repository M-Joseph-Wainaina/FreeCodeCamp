string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);

Console.WriteLine(updatedData);
//Console.

string message = "This--is--ex-amp-le--da-ta";
string editedMessage = message.Replace("--", " ");
editedMessage = editedMessage.Replace("-", "");

Console.WriteLine(editedMessage);
editedMessage  = editedMessage.Remove(0, 4);
Console.WriteLine(editedMessage);