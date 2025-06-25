namespace LambdaSubmossion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>() // Creates a List object with 10 Employee objects within
            {
                 new Employee(1, "Joe", "Anderson"),
                 new Employee(2, "Emily", "Clark"),
                 new Employee(3, "Michael", "Thompson"),
                 new Employee(4, "Sarah", "Lee"),
                 new Employee(5, "Joe", "Martinez"),
                 new Employee(6, "David", "Nguyen"),
                 new Employee(7, "Anna", "Patel"),
                 new Employee(8, "James", "Wright"),
                 new Employee(9, "Laura", "Scott"),
                 new Employee(10, "Brian", "Kim")
            };

            List<Employee> firstNameJoe = new List<Employee>(); // Creates a new empty List object
            foreach (Employee employee in employees) // Iterates through the employees list
            {
                if (employee.FirstName == "Joe") // Checks if the class property is equal to "Joe"
                {
                    firstNameJoe.Add(employee); // Adds current elements into firstNameJoe list
                }
            }
            Console.WriteLine(firstNameJoe.Count()); // Prints a number of elements in the firstNameJoe list

            Console.WriteLine(); // Prints an empty line in the console

            // Creates a new list from the employees list with
            // only those Employee objects that have value "Joe" as FirstName property
            List<Employee> firstNameJoeLambda = employees.Where(x => x.FirstName.Equals("Joe")).ToList();
            Console.WriteLine(firstNameJoeLambda.Count()); // Prints a number of elements in the firstNameJoeLambda list
        }
    }
}
