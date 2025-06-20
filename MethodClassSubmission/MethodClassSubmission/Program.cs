namespace MethodClassSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates an instance of MathOperations class
            MathOperations mathOperations = new MathOperations();
            // Calls the MathOperation method passing in two numbers
            mathOperations.MathOperation(103, 19);
            // Calls the MathOperation method specifying the parameters by name
            mathOperations.MathOperation(numOne: 103, numTwo: 19);
        }
    }
}
