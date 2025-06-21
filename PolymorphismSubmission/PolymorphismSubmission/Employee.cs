namespace PolymorphismSubmission
{
    internal class Employee : Person, IQuittable // This class is inherited from the class Person
    {
        public override void SayName() // Overrides the abstract method SayName
        {
            // Prints inherited properties in the console
            Console.WriteLine($"Name: {this.FirstName} {this.LastName}");
        }
        public void Quit() // Overrides the method from the inherited interface
        {
            Console.WriteLine("I QUIT!");
        }
    }
}
