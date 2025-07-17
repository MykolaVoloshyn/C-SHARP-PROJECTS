using System.Data.Entity;

namespace EFCodeFirstConsoleApp
{
    internal class StudentDatabaseContext : DbContext
    {
        public StudentDatabaseContext() : base() { }

        public DbSet<Student> Students { get; set; }
    }
}
