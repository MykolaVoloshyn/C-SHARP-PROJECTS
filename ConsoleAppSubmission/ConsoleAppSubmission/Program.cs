Console.WriteLine("Guess a number!");
// Saves a random number between 1 and 10
short randomNumber = Convert.ToInt16(new Random().Next(1, 11));
// Convert entered number to short data type and saves it
Console.WriteLine("Enter any number between 1 and 10.");
short number = Convert.ToInt16(Console.ReadLine());

do
{
    // This block of code prints the message congratulating on victory if user guess the number
    if (number == randomNumber)
    {
        Console.WriteLine("Congratulation, You won!");
        break;
    }

    Console.WriteLine("Enter any number between 1 and 10.");
    // Convert entered number to short data type and saves it
    number = Convert.ToInt16(Console.ReadLine());
}
while (number != randomNumber);

Console.WriteLine(); // Prints an emplty line in the console

short total = 1;
while (total < 6) // Checks if total less than 6
{
    Console.WriteLine(total);
    total++; // Increases total by 1

}