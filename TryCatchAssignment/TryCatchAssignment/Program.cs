DateTime currentDate = DateTime.Now; // Get the current date and time

while (true)
{
    try // Start of try block to catch exceptions
    {
        Console.Write("Please enter your age: ");
        // Using uint to ensure only positive integers are accepted
        uint userAge = uint.Parse(Console.ReadLine());
        if (userAge != 0) // Check if the age is greater than zero
        {
            // Calculate the year of birth by subtracting the age from the current year
            int yearOfBirth = currentDate.AddYears((int)-userAge).Year;
            Console.WriteLine($"You were born in year: {yearOfBirth}"); // Output the year of birth
            break; // Exit the loop if parsing is successful
        }
        else
        {
            Console.WriteLine("Please enter a positive number greater than zero.\n");
        }
    }
    catch (FormatException) // Catch block for format exceptions
    {
        Console.WriteLine("Please enter only digits, no decimals.\n");
    }
    catch (OverflowException) // Catch block for overflow exceptions
    {
        Console.WriteLine("Please enter a positive number greater than zero.\n");
    }
    catch (Exception ex) // Catch block for any other unexpected exceptions
    {
        Console.WriteLine($"An unexpected error occurred: {ex.Message}\n");
    }
}

Console.WriteLine("Press any key to exit..."); // Prompt to exit the program
Console.ReadKey();