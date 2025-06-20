namespace MethodsAndObjectsSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates an instance of the class Employee passing two arguments
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName(); // Calls class method

            Console.WriteLine("Press any key to exit.");
            // Keeps the program running until the user press any key to close it
            Console.ReadKey();
        }
    }
}
