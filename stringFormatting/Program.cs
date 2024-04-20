// Composite Formatting
Console.Clear();
Console.WriteLine("Composite Formatting?");

string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

// string interpolation
Console.WriteLine();
Console.WriteLine("string interpolation");

string first1 = "Hello";
string second1 = "World";
Console.WriteLine($"{first1} {second1}!");
Console.WriteLine($"{second1} {first1}!");
Console.WriteLine($"{first1} {first1} {first1}!");

// Formatting currency
Console.WriteLine();
Console.WriteLine("Formatting currency");

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// Formatting numbers
Console.WriteLine();
Console.WriteLine("Formatting numbers");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

// Formatting percentages
Console.WriteLine();
Console.WriteLine("Formatting percentages");

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

// Combining formatting approaches
Console.WriteLine();
Console.WriteLine("Combining formatting approaches");

decimal price1 = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price1 - salePrice), price1);
yourDiscount += $"A discount of {((price1 - salePrice)/price1):P2}!"; //inserted

Console.WriteLine(yourDiscount);

// Display the invoice number using string interpolation
Console.WriteLine();
Console.WriteLine("Display the invoice number using string interpolation");

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");

// Working with padded strings
Console.WriteLine();
Console.WriteLine("Working with padded strings");

string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);

 Console.WriteLine("1234567890123456789012345678901234567890");
 Console.WriteLine(formattedLine);