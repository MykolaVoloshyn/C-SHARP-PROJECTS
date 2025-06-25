namespace StructAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number(); //Decleres a new variable
            number.Amount = 3; // Assigns a new value to  the variable
            Console.WriteLine(number.Amount); // Prints in the console the variable's value
        }

        struct Number // Creates a struct value type
        {
            public decimal Amount; // Struct member
        }
    }
}
