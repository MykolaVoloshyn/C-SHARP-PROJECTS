namespace BooleanLogicSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval Program\n"); // Prints passed text in the console.

            Console.WriteLine("\nWhat's your age?:");
            // Converts ures's input to short data type and saves in variable clientAge
            short clientAge = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nHave yo ever had a DUI? Please answer yes or no:");
            string answer = Console.ReadLine(); // Saves user's input
            bool hadDUI;
            // This block of code chacks if the variable answer is yes or no and
            // assigns value true or false accordingly to the variable hadDUI
            switch (answer)
            {
                case "yes":
                    hadDUI = true;
                    break;
                case "no":
                    hadDUI = false;
                    break;
                default:
                    hadDUI = true;
                    break;
            }

            Console.WriteLine("\nHow many speeding tickets do you have?");
            // Converts ures's input to short data type and saves in variable speedingTicketsNumber
            short speedingTicketsNumber = Convert.ToInt16(Console.ReadLine());

            // Checks if the user is older than 15, has no DUI, and doesn't have more than 3 speeding tickets
            bool isQualified = clientAge > 15 && hadDUI == false && speedingTicketsNumber <= 3;

            Console.WriteLine("\nQualified?");
            Console.WriteLine(isQualified); // Prints passed text in the console.

            // This block of code prints in the console text with decision depending on
            // whether the client is qualified for the insurance
            switch (isQualified)
            {
                case true:
                    Console.WriteLine("\nYou were approved for a car insurance.");
                    break;
                case false:
                    Console.WriteLine("\nUnfortinatelly, you were not approved for a car insurance.");
                    break;
            }

            Console.WriteLine("\n\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
