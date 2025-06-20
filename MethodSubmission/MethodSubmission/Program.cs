namespace MethodSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOperations = new MathOperations(); // Creates a new instance of MathOperations class
            int firstNumber;
            int secondNumber;

            Console.WriteLine("Please enter first number you want to make mathematical operation with :");
            string userFirstNumber = Console.ReadLine(); // Saves user's input

            // This try/catch block converts user's input into int data type or
            // print the errorw message if the input wasn't a number
            try
            {
                firstNumber = Convert.ToInt32(userFirstNumber);

            }
            catch (Exception ex)
            {
                Console.WriteLine("\nEntered data was not a number");
                return;
            }

            Console.WriteLine("\nPlease enter second number you want to make mathematical operation with :");
            Console.WriteLine("(the second number is optional. you can skip it by pressing 'Enter')");
            string userSecondNumber = Console.ReadLine(); // Saves user's input

            if (!string.IsNullOrEmpty(userSecondNumber)) // Checks if the user entered any data for the second number
            {
                try
                {
                    secondNumber = Convert.ToInt32(userSecondNumber); // Converts user's input into int data type
                    Console.Write("\nThe result of the MathOperation method is: ");
                    // Prints the result of called MathOperation method with two arguments passed
                    Console.WriteLine(mathOperations.MathOperation(firstNumber, secondNumber));
                }
                catch (Exception ex)
                {
                    // Prints the errorw message if the input wasn't a number
                    Console.WriteLine("\nEntered data was not a number.");
                }
            }
            else // Works when the user decided to skip the second number
            {
                Console.Write("\nThe result of the MathOperation method is: ");
                // Prints the result of called MathOperation method with one argument passed
                Console.WriteLine(mathOperations.MathOperation(firstNumber));
            }

            Console.Write("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
