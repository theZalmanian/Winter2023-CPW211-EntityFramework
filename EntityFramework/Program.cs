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

            // Select all Students from DB w/ EF Core
            List<Student> allStudents = dbContext.Students.ToList(); // Method Syntax

            // OR

            //  allStudents = (from stu in dbContext.Students
            //                 select stu).ToList(); // Query syntax

            foreach (Student currStudent in allStudents)
            {
                Console.WriteLine($"{currStudent.FullName}'s email address is: {currStudent.EmailAddress}");
            }
        }
    }
}