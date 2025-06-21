namespace PolymorphismSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates an object of IQuittable interface using interface polymorphism
            IQuittable quittengEmployee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"
            };
            // Calls the Quit method
            quittengEmployee.Quit();

            // Keeps the program running till the user press any key
            Console.ReadKey(); 

        }
    }
}
