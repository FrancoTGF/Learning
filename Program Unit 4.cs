// Basic methods to modify text
//string text = "Hello";
//Console.WriteLine(text.ToUpper());
//Console.WriteLine(text.ToLower());
//Console.WriteLine(text.Replace("H", "J"));
//Console.WriteLine(text.Length);

// Concatenation (+)
//Console.WriteLine(first + "," + last + "!");

// String interpolation ($"...")
//Console.WriteLine($"Hello, {name}!");

// Concatenation use example
//string first = "Hello";
//string last = "world";
//string message = first + ", " + last + "!";
//Console.WriteLine(message);

// String interpolation
//string name = "Alex";
//Console.WriteLine($"Hello, {name}!");

// Combination of WriteLine, ReadLine, string method and interpolation
Console.WriteLine("What's your name? ");
string name = Console.ReadLine();
string greeting = $"Welcome, {name.ToUpper()}!";
Console.WriteLine(greeting);