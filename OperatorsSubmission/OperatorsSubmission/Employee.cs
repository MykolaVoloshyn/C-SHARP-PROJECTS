namespace OperatorsSubmission
{
    internal class Employee
    {
        public string FirstName { get; set; } // Class property
        public string LastName { get; set; } // Class property
        public int Id { get; set; }  // Class property

        // Overloads the '==' operator for the class Employee
        public static bool operator ==(Employee employeeOne, Employee employeeTwo)
        {
            return employeeOne.Id == employeeTwo.Id;
        }

        // Overloads the '!=' operator for the class Employee
        public static bool operator !=(Employee employeeOne, Employee employeeTwo) => !(employeeOne == employeeTwo);
    }
}
