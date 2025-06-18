// Creates a list of integers
List<int> intList = new List<int> { 8, 15, 14, 76, 35, 25, 78, 65, 48, 21, 48, 64, 34 };

try // try statment checks the code within for errors while it is being executed.
{
    Console.WriteLine("Please enter a number to divide each number in the list by!");
    int userInt = Convert.ToInt32(Console.ReadLine()); // Convert user's input into int

    // This block of code loops through elements in the list and
    // prints the result of dividing each element by the number entered by the user
    foreach (int i in intList)
    {
        Console.WriteLine(i / userInt);
    }
}
// This block of code print error message whent FormatException occurs
catch (FormatException e)
{
    Console.WriteLine("\n" + e.Message);
}
// This block of code print error message whent DivideByZeroException occurs
catch (DivideByZeroException e)
{
    Console.WriteLine("\n" + e.Message);
}

Console.WriteLine("\nThe program has emerged from the try/catch block");
