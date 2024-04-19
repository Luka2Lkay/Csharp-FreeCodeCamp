// Write code that attempts to add an int and a string and save the result in an int
Console.Clear();

// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result);

//Is it possible that attempting to change the value's data type would result in a loss of information?

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

//Perform a cast
Console.WriteLine();
decimal myDecimal2 = 3.14m;
Console.WriteLine($"decimal2: {myDecimal2}");

int myInt2 = (int)myDecimal2;
Console.WriteLine($"int2: {myInt2}");

// You can observe from the output that casting a decimal into a float is a narrowing conversion because you're losing precision.

Console.WriteLine();
decimal myDecimal3 = 1.23456789m;
float myFloat = (float)myDecimal3;

Console.WriteLine($"Decimal3: {myDecimal3}");
Console.WriteLine($"Float3  : {myFloat}");


// Here's a quick example of using the ToString() method to explicitly convert int values into strings.

Console.WriteLine();
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

Console.WriteLine("Convert a string to an int using the Parse() helper method");
// Most of the numeric data types have a Parse() method, which converts a string into the given data type. In this case, you use the Parse() method to convert two strings into int values, then add them together.

Console.WriteLine();
string first2 = "5";
string second2 = "7";
int sum = int.Parse(first2) + int.Parse(second2);
Console.WriteLine(sum);

Console.WriteLine("Convert a string to a int using the Convert class");

Console.WriteLine();
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

Console.WriteLine("Compare casting and converting a decimal into an int");

Console.WriteLine();
int value3 = (int)1.5m; // casting truncates
Console.WriteLine(value3);

int value4 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value4);

Console.WriteLine("TryParse() a string into an int");

Console.WriteLine();
string value = "102";
int result2 = 0;
if (int.TryParse(value, out result2))
{
   Console.WriteLine($"Measurement: {result2}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

Console.WriteLine("Use the parsed int later in code");

string value5 = "102";
int result3 = 0;
if (int.TryParse(value5, out result3))
{
   Console.WriteLine($"Measurement: {result3}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result3}");

Console.WriteLine("Modify the string variable to a value that can't be parsed");

Console.WriteLine();
string value6 = "bad";
int result4 = 0;
if (int.TryParse(value6, out result4))
{
   Console.WriteLine($"Measurement: {result4}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

if (result4 > 0)
   Console.WriteLine($"Measurement (w/ offset): {50 + result}");

   //Exercise - Complete a challenge to combine string array values as strings and as integers
   Console.WriteLine();
   Console.WriteLine("Challenge 1");

string[] myValues = { "12.3", "45", "ABC", "11", "DEF" };  
    double total = 0;
    double numAns = 0;
    string myMessage = "";

foreach(string myValue in myValues) {

    if(double.TryParse(myValue, out total)) {
      numAns  += total;
    } else {
        myMessage += myValue; 
    }
    
}
Console.WriteLine($"Message: {myMessage}");
Console.WriteLine($"total: {numAns}");

//  Complete a challenge to output math operations as specific number types
Console.WriteLine();
Console.WriteLine("Challenge 2");

int value7 = 11;
decimal value8 = 6.2m;
float value9 = 4.3f;

int result5 = Convert.ToInt32(value7/value8);
decimal result6 = value8 /(decimal)value9;
float result7 = value9/value7;
// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)

Console.WriteLine($"Divide value1 by value2, display the result as an int: {result5}");

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result6}");

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result7}");




