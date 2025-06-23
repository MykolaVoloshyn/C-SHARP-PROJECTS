namespace ParsingEnumsSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the current day of the week: ");
            string userInput = Console.ReadLine(); // Saves user input

            try
            {
                // Converts user input into enum data type
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput, true);

            }
            catch (Exception)
            {
                // Prints message if an error occurs
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey(); // Keeps the program runnig till the user press any key
        }

        public enum DaysOfTheWeek
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
    }
}
