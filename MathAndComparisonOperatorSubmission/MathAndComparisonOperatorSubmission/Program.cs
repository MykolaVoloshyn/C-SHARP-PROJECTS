namespace MathAndComparisonOperatorSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program."); //Prints passed text in the console.

            Console.WriteLine("\nPerson 1");
            Console.WriteLine("\nWhat's your hourly rate?");
            //Converets user input to double data type and saves the ansver in variable person1HourlyRate
            double person1HourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            //Converets user input to double data type and saves the ansver in variable person1WorkHours
            double person1WorkHours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPerson 2");
            Console.WriteLine("\nWhat's your hourly rate?");
            //Converets user input to double data type and saves the ansver in variable person2HourlyRate
            double person2HourlyRate = Convert.ToDouble(Console.ReadLine()); person1WorkHours
            Console.WriteLine("How many hours do you work per week?");
            //Converets user input to double data type and saves the ansver in variable person2WorkHours
            double person2WorkHours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nAnnual salary of Person 1:");
            // Calculates the first user's annual salary
            double person1AnnualSalary = person1HourlyRate * person1WorkHours * 52; //52 -> weeks in a year
            Console.WriteLine(person1AnnualSalary);

            Console.WriteLine("\nAnnual salary of Person 2:");
            // Calculates the second user's annual salary
            double person2AnnualSalary = person2HourlyRate * person2WorkHours * 52; //52 -> weeks in a year
            Console.WriteLine(person2AnnualSalary);

            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            // Prints 'True' if the first user earns more than the second user or 'False' if opposite.
            Console.WriteLine(person1AnnualSalary > person2AnnualSalary);

            // This block of code keeps program running until user press any key to close the program
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
