namespace ClassSubmission
{
    internal static class MathOperations
    {
        // Creates the MathOperation method that returns nothing
        public static void MathOperation(int number)
        {
            Console.WriteLine(number / 2);
        }

        // Overloads the MathOperation method
        public static void MathOperation()
        {
            Console.WriteLine("Overloaded method");
        }
    }
}
