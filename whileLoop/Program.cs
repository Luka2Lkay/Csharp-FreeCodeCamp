// string? readResult;
// bool validInput = false;
// int value = 0;
// string valueEntered = "";

// Console.WriteLine("Enter an interger value between 5 and 10.");

// do {
//     readResult = Console.ReadLine();
// if (readResult != null) {
//     valueEntered = readResult;
//     }

// validInput = int.TryParse(valueEntered, out value);

// if(validInput == true) {
//   if(value < 5 || value > 10) {
//     validInput = false;
//         Console.WriteLine($"You entered {value}. Please enter a number between 5 and 10.");
//     return;
//     } 
// }else{
//         Console.WriteLine("Sorry, you entered an invalid number, please try again.");
// return;
//     }
  
// } while (validInput == false);

// Console.WriteLine($"Your input value ({value}) has been accepted!");

// string? readResult;
// bool validName = false;
// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

// do {
//     readResult = Console.ReadLine().ToLower();

//     if(readResult != "administrator" || readResult != "manager" || readResult != "user"){
//         Console.Write($"The role name that you entered, \"{readResult}\" is not valid. ");
//         Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
//             readResult = Console.ReadLine();
        
//     }
// validName = true;
// } while(validName == false);

// Console.WriteLine($"Your input value ({readResult}) has been accepted.");

string[] myStrings = new string[2] {"I like pizza. i like roast chicken. i like salad", "i like all three of the menu choises"};
int periodicLocation = 0;
string myString = "";

for (int i = 0; i < myStrings.Length; i++) {
myString = myStrings[i];
periodicLocation = myString.IndexOf(".");
string mySentence;

while(periodicLocation != -1) {
    mySentence = myString.Remove(periodicLocation);
    myString = myString.Substring(periodicLocation + 1);
    myString = myString.TrimStart();
    periodicLocation = myString.IndexOf(".");

    Console.WriteLine(mySentence);
}

mySentence = myString.Trim();
Console.WriteLine(mySentence);

}
