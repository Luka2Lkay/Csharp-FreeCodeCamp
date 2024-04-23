// Write code to find parenthesis pairs embedded in a string
Console.Clear();
Console.WriteLine("Write code to find parenthesis pairs embedded in a string");

string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

// Retrieve the last occurrence of a sub string
Console.WriteLine();
Console.WriteLine("Retrieve the last occurrence of a sub string");

