namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add Student to DB w/ EF Core
            using StudentContext dbContext = new();

            // Create a student
            Student currStudent = new()
            {
                FullName = "Reality Undefined",
                DateOfBirth = new DateTime(1973, 1, 15),
                EmailAddress = "Reality.UD@email.com"
            };

            // Prepares the Student insert statement
            dbContext.Students.Add(currStudent);

            // Execute the pending insert query
            dbContext.SaveChanges();
        }
    }
}