namespace EFCodeFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentDatabaseContext())
            {
                var student = new Student()
                {
                    FirstName = "Piter",
                    LastName = "Jonson",
                    DateOfBirth = new DateOnly(2007, 5, 14),
                    Major = "Computer Science",
                    GPA = 3.85f

                };
                context.Students.Add(student);
                context.SaveChanges();
            }
        }
    }
}
