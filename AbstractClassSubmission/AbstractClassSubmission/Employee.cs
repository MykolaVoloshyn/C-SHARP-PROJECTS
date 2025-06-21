namespace AbstractClassSubmission
{
    internal class Employee : Person // This class is inherited from the class Person
    {
        public override void SayName() // Overrides the abstract method SayName
        {
            // Prints inherited properties in the console
            Console.WriteLine($"Name: {this.FirstName} {this.LastName}");
        }
    }
}
