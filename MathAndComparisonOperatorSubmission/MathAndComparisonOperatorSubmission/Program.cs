namespace MathAndComparisonOperatorSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program.");

            Console.WriteLine("\nPerson 1");
            Console.WriteLine("\nWhat's your hourly rate?");
            double person1HourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            double person1WorkHours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPerson 2");
            Console.WriteLine("\nWhat's your hourly rate?");
            double person2HourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            double person2WorkHours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nAnnual salary of Person 1:");
            double person1AnnualSalary = person1HourlyRate * person1WorkHours * 52; //52 -> weeks in a year
            Console.WriteLine(person1AnnualSalary);

            Console.WriteLine("\nAnnual salary of Person 2:");
            double person2AnnualSalary = person2HourlyRate * person2WorkHours * 52; //52 -> weeks in a year
            Console.WriteLine(person2AnnualSalary);

            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            Console.WriteLine(person1AnnualSalary > person2AnnualSalary);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
