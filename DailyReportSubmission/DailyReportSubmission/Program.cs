namespace DailyReportSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Prints passed text in the console
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");

            Console.WriteLine("\n\nWhat is your name?");
            // Saves user's input in a variable userName
            string userName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            // Saves user's input in a variable userCourse
            string userCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            // Converts user's input to short data type and saves in a variable coursePage
            short coursePage = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            // Converts user's input to bool data type and saves in a variable userNeedsHelp
            bool userNeedsHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics.");
            // Saves user's input in a variable positiveExperienceFeedback
            string positiveExperienceFeedback = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to share? Please be specific.");
            // Saves user's input in a variable otherFeedback
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            // Converts user's input to short data type and saves in a variable studyHours
            short studyHours = Convert.ToInt16(Console.ReadLine());

            // Prints passed text in the console
            Console.WriteLine("\n\nThank you for your answers. An Instructor will respond to this shortly.Have a great day!");
        }
    }
}
