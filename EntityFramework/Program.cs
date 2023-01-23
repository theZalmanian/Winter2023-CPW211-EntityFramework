namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add Student to DB w/ EF Core
            using StudentContext dbContext = new();

            // Create a student
            Student currStudent1 = new()
            {
                FullName = "Reality Undefined",
                DateOfBirth = new DateTime(1973, 1, 15),
                EmailAddress = "RealUnd@school.edu"
            };

            // Create another student
            Student currStudent2 = new()
            {
                FullName = "Whenever Forever",
                DateOfBirth = new DateTime(1991, 6, 21),
                EmailAddress = "WhenFor@school.edu"
            };

            // Prepares the Student insert statements
            dbContext.Students.Add(currStudent1);
            dbContext.Students.Add(currStudent2);

            // Execute all pending insert query
            dbContext.SaveChanges();

            // Select Student from DB w/ EF Core
        }
    }
}