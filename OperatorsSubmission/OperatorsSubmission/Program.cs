namespace OperatorsSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates an objects of the Employee class
            Employee firstEmployee = new Employee
            {
                FirstName = "Michael",
                LastName = "Johnson",
                Id = 10532
            };
            // Creates an objects of the Employee class
            Employee SecondEmployee = new Employee()
            {
                FirstName = "John",
                LastName = "Smith",
                Id = 14054
            };
            Console.Write("Have the same ID number: ");
            // Compares if two Employee objects are equal by comparing their Id property 
            Console.WriteLine(firstEmployee == SecondEmployee);
            Console.Write("\nHave different ID numbers: ");
            // Compares if two Employee objects are not equal by comparing their Id property
            Console.WriteLine(firstEmployee != SecondEmployee);
        }
    }
}
