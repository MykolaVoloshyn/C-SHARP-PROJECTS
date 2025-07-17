namespace EFCodeFirstConsoleApp
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Major { get; set; }
        public float GPA { get; set; }
    }
}
