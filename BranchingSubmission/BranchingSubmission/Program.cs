namespace BranchingSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prints welcome text in the console
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n\n");

            Console.WriteLine("Please enter the weight of your package, lb:");
            // Converts user's input to double data type and saves it in the packageWeight variable
            double packageWeight = Convert.ToDouble(Console.ReadLine());

            // Display the error message if the package weight is greater than 50 lb
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            Console.WriteLine("\nPlease enter the width of your package, in:");
            // Converts user's input to double data type and saves it in the packageWidth variable
            double packageWidth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nPlease enter the height of your package, in:");
            // Converts user's input to double data type and saves it in the packageHeight variable
            double packageHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nPlease enter the length of your package, in:");
            // Converts user's input to double data type and saves it in the packageLength variable
            double packageLength = Convert.ToDouble(Console.ReadLine());

            // Displays the error message if the dimensions total is greater than 50 in
            if ((packageWidth + packageHeight + packageLength) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Calculates the quote
            double quote = (packageWidth * packageHeight * packageLength * packageWeight) / 100.00;

            // Prints price for shipping
            Console.WriteLine($"\nYour estimated total for shipping this package is: ${quote:F2}.\nThank you!");

            // This block of code keeps program running until user press any key to close the program
            Console.WriteLine("\nPlease enter any key to exit.");
            Console.ReadKey();
        }
    }
}
