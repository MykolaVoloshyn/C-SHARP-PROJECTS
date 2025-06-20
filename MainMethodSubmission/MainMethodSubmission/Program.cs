namespace MainMethodSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOperations = new MathOperations(); // Creates an instance of MathOperations class

            int firstResult = mathOperations.MathOperation(9); // Calls MathOperation method passing an integer
            Console.WriteLine("Result of the first method: {0}", firstResult); // Prints the result of the first method

            int secondResult = mathOperations.MathOperation(7.3f); // Calls MathOperation method pasing a float
            Console.WriteLine("Result of the second method: {0}", secondResult); // Prints the result of the second method

            int thirdResult = mathOperations.MathOperation("11"); // Calls MathOperation method a string
            Console.WriteLine("Result of the third method: {0}", thirdResult); // Prints the result of the third method
        }
    }
}
