Console.WriteLine(DateTime.Now); // Prints the current date and time
Console.WriteLine("Please enter any number."); // Prints the passed text to user
string userInput = Console.ReadLine(); // Saves user input data

// Prints to the console the exact time it will be in X hours, where X - userInput 
Console.WriteLine($"In {userInput} hours it will be: {DateTime.Now.AddHours(Convert.ToDouble(userInput))}");

Console.WriteLine("Press any key to exis the program.");
Console.ReadKey();
