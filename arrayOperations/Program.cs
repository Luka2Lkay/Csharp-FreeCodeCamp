//Create an array of pallets, then sort them
Console.Clear();
Console.WriteLine();
Console.WriteLine("Create an array of pallets, then sort them");

string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Reverse the order of the pallets
Console.WriteLine();
Console.WriteLine("Reverse the order of the pallets");

string[] pallets2 = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets2);
foreach (var pallet in pallets2)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets2);
foreach (var pallet in pallets2)
{
    Console.WriteLine($"-- {pallet}");
}

//Use array methods to clear and resize an array
Console.WriteLine();
Console.WriteLine("Use array methods to clear and resize an array");

string[] pallets3 = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets3, 0, 2);
Console.WriteLine($"After: {pallets[0]}");

Console.WriteLine($"Clearing 2 ... count: {pallets3.Length}");
foreach (var pallet in pallets3)
{
    Console.WriteLine($"-- {pallet}");
}

// Resize the array to add more elements
Console.WriteLine();
Console.WriteLine("Resize the array to add more elements");

string[] pallets4 = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets4, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets4.Length}");
foreach (var pallet in pallets4)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets4.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Resize the array to remove elements
Console.WriteLine();
Console.WriteLine("Resize the array to remove elements");

string[] pallets5 = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets5, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets5.Length}");
foreach (var pallet in pallets5)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets5, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets5.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets5, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets5.Length}");

foreach (var pallet in pallets5)
{
    Console.WriteLine($"-- {pallet}");
}

// Use the ToCharArray() to reverse a string

Console.WriteLine();
Console.WriteLine("Use the ToCharArray() to reverse a string");

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);

// Write code to reverse each word in a message

Console.WriteLine();
Console.WriteLine("Write code to reverse each word in a message");

string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(" ");

string newString = "";

foreach(string word in words) {
    char[] str = word.ToCharArray();
    Array.Reverse(str);

    newString += new string(str) + " ";
}

Console.WriteLine(newString);

// parse a string of orders, sort the orders and tag possible errors

Console.WriteLine();
Console.WriteLine("parse a string of orders, sort the orders and tag possible errors");

string orderStream1 = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] ids = orderStream1.Split(',');

Array.Sort(ids);

foreach (string id in ids) {
   
    if(id.Length != 4) {
        Console.WriteLine($"{id} - Error");
    } else {
Console.WriteLine(id);
    }

     
}