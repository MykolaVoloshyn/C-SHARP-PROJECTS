namespace ClassSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates an instance of the MathOperations class
            MathOperations mathOperations = new MathOperations();
            Console.WriteLine("Please enter any number");
            // Converts users input into int data type and saves it
            int userInput = Convert.ToInt32(Console.ReadLine());
            // Calls the MathOperation method with one argument passed
            mathOperations.MathOperation(userInput);
            // Calls the MathOperation method with no arguments passed
            mathOperations.MathOperation();

        }
    }
}
