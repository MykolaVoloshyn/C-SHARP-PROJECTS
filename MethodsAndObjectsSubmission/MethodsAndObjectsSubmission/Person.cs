namespace MethodsAndObjectsSubmission
{
    internal class Person
    {
        public string FirstName { get; set; } // Class property
        public string LastName { get; set; } // Class property

        public void SayName() // Class method
        {
            // Prints in the console FirstName and LastName
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
