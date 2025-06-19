namespace CallingMethodsSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to do the math operations on?");
            // Converts user's input into int data type and saves in userNumber variable
            int userNumber = Convert.ToInt32(Console.ReadLine());

            SimpleMath simpleMath = new SimpleMath(); // Creates an instance of SimpleMath class

            // Passes userNumber to ToSecondPower method and saves the result
            int firstMethod = simpleMath.ToSecondPower(userNumber);
            Console.WriteLine(firstMethod); // Prints the result

            // Passes userNumber to ToThirdPower method and saves the result
            int secondMethod = simpleMath.ToThirdPower(userNumber);
            Console.WriteLine(secondMethod); // Prints the result

            // Passes userNumber to IncreaseByTen method and saves the result
            // Because this method is static we can call it without created class instance
            int thirdMethod = SimpleMath.IncreaseByTen(userNumber);
            Console.WriteLine(thirdMethod); // Prints the result
        }
    }
}
