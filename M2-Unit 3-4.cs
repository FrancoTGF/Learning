// Declare and asign variables

string name = "Alice";
int age = 25;
decimal temperature = 98.6;
bool isRaining = true;

// Variables can be declared and assigned in the same line or delcared in one line and asigned value in another line.
// The variable has to be declared in a line before the value is asigned

// Variable naming conventions: 
// - start with a lower case letter and the next words with an upper case letter.
// - Use descriptive names for the variables (so you actually remember what the variable stores)
// - Use full words and not acronyms or abbreviations.

// UNIT 4 - "var" key

// It auto assigns a type to the variable. It won't allow to change the variable type after it was assigned.

var message = "Hello!";  // assigns a string value, it won't allow inserting a numerical value after that, it will count as a string.
var favorite = 42;       // assigns a int value.
var average = 87.5;      // assigns 

Console.WriteLine(message);
Console.WriteLine(favorite);
Console.WriteLine(average);