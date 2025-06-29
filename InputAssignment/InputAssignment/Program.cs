Console.WriteLine("Please enter any number"); // Prints passed text
string inputNumber = Console.ReadLine(); // Saves user's entered number to the variable

// Creates a StreamWriter object to append user's entered number to a file, and
// ensures it will be automatically closed and disposed when it goes out of scope.
using StreamWriter file = new StreamWriter(@"D:\The Tech Academy\log.txt", true);
file.WriteLine($"{inputNumber};"); // Appends the entered number to the file

Console.WriteLine($"You've entered: {inputNumber}"); // Prints users number in the console