using System.Globalization;

namespace SixPartAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment Part 1
            // Creates an array of names.
            string[] stringArray = { "Emily", "Jake", "Ashley", "Brandon", "Madison", "Tomas", "Sheldon" };
            Console.WriteLine("Please enter some text.");
            string userText = Console.ReadLine(); // Saves user's input.

            // This block of code concatinate each element of the array with users input.
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += userText;
            }

            // This block of code prints each element of the array.
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            Console.WriteLine(); // Prints a new line in the console.


            // Assignment Part 2
            Console.WriteLine("Fixing an infinite loop.");
            int total = 0;
            while (total < 15)
            {
                Console.WriteLine(total);
                total++; // Added this line to fix the infinite loop.
            }

            Console.WriteLine(); // Prints a new line in the console.


            // Assignment Part 3
            Console.WriteLine("Iterating the loop using a \"<\" operator");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"i = {i}");
            }

            Console.WriteLine("\nIterating the loop using a \"<=\" operator");
            for (int j = 0; j <= 3; j++)
            {
                Console.WriteLine($"j = {j}");
            }
            Console.WriteLine(); // Prints a new line in the console.


            // Assignment Part 4
            // Creates a list of car brands.
            List<string> carBrands = new List<string>
            {
                "Toyota", "Honda", "Ford", "Chevrolet", "BMW", "Mercedes", "Audi", "Volkswagen",
                "Hyundai", "Nissan", "Kia", "Mazda", "Subaru", "Lexus","Jeep", "Porsche","Tesla",
                "Volvo", "Jaguar", "Ferrari"
            };
            // This variable is used to determine when to exit the while loop.
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Please enter a name of a car brand you want to find.");
                // Saves user input
                string userInput = Console.ReadLine();
                // Converts the first character into uppercase using .ToTitleCase method.
                string capitalized = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(userInput);

                // This block of code checks if user input matches with any item in the list then
                // prints the index of matched item and exit the loop.
                if (carBrands.Contains(capitalized))
                {
                    Console.WriteLine($"{capitalized} is located under the index: {carBrands.IndexOf(capitalized)}");
                    flag = false;
                }
                // This block of code prints the message that there is no match and
                // gives a user option to continue searching or exit.
                else
                {
                    Console.WriteLine("Sorry, your input is not in the list");
                    Console.Write("Would you like to try again?\nto exit press 'n'; to continue press any other button : ");
                    string keepGoing = Console.ReadLine();

                    if (keepGoing == "n") flag = false;
                }
            }
            Console.WriteLine(); // Prints a new line in the console.


            // Assignment Part 5
            // Creates a list of months
            List<string> months = new List<string>()
            {
                "July", "February", "March", "December", "June", "January", "March", "October", "May",
                "August", "September", "April", "December", "October", "July", "November"
            };

            Console.Write("Please, enter the name on a month: ");
            string searchedMonth = Console.ReadLine(); // Saves user's input
            // Converts the first character into uppercase using .ToTitleCase method.
            string capitalizedInput = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchedMonth);

            // This block of code checks if there is a match and prints the index of the matched month
            if (months.Contains(capitalizedInput))
            {
                for (int i = 0; i < months.Count; i++)
                {
                    if (months[i] == capitalizedInput)
                    {
                        Console.WriteLine("There is a match at index:" + " " + i);
                    }
                }
            }
            // This block of code prints error message if there is no match with user's input
            else
            {
                Console.WriteLine($"Sorry, there is no \"{capitalizedInput}\" in the list.");
            }
            Console.WriteLine(); // Prints a new line in the console.

            // Assignment Part 6
            // Creates a list of fruits
            List<string> fruits = new List<string>()
            {
                "orange", "pear", "kiwi", "plum", "peach", "grape", "kiwi", "strawberry", "apricot",
                "apple", "banana", "pineapple", "cherry", "pear", "peach", "avocado"
            };
            // Creates a HashSet object that contains no duplicates, only unique elements
            HashSet<string> fruitsHashSet = new HashSet<string>();

            foreach (string fruit in fruits) // Evaluates each item in the list
            {
                if (!fruitsHashSet.Contains(fruit)) // Checks if an elements is unique
                {
                    Console.WriteLine($"{fruit} is a unique item.");
                    fruitsHashSet.Add(fruit); // Adds a unique element to the HashSet
                    continue; // Breaks one iteration in the loop
                }

                Console.WriteLine($"{fruit} is a duplicate.");
            }

            Console.WriteLine("\nPress any key to exit the program.");
            Console.ReadKey();

        }
    }
}
