namespace DailyReportSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");

            Console.WriteLine("\n\nWhat is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string userCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            short coursePage = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool userNeedsHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperienceFeedback = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to share? Please be specific.");
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            short studyHours = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\n\nThank you for your answers. An Instructor will respond to this shortly.Have a great day!");
        }
    }
}
