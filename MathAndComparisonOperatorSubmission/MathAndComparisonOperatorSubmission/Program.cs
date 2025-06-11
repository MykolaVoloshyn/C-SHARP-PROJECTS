namespace MathAndComparisonOperatorSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program.");

            Console.WriteLine("\nPerson 1");
            Console.WriteLine("\nWhat's your hourly rate?");
            double hourlyRate1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            double workHours1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPerson 2");
            Console.WriteLine("\nWhat's your hourly rate?");
            double hourlyRate2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            double workHours2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nAnnual salary of Person 1:");
            double annualSalary1 = hourlyRate1 * workHours1 * 52;
            Console.WriteLine(annualSalary1);

            Console.WriteLine("\nAnnual salary of Person 2:");
            double annualSalary2 = hourlyRate2 * workHours2 * 52;
            Console.WriteLine(annualSalary2);

            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            Console.WriteLine(annualSalary1 > annualSalary2);
        }
    }
}
