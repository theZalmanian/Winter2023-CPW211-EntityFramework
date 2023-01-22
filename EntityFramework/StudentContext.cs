using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class StudentContext : DbContext
    {
        public StudentContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Server = The server we are connecting to
            // Database = The name of the database
            // Trusted_Connection = Indicates that a windows account should be used
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=EFCoreExample; Trusted_Connection=True;");
        }
    }
}
