namespace AbstractClassSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates an instance of the Employee class passing two arguments
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName(); // Calls SayName method

            Console.ReadKey(); // Keep the program open till the user press any key
        }
    }
}
