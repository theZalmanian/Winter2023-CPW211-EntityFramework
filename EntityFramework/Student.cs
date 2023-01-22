using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    /// <summary>
    /// Represents an individual college student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The student's ID number
        /// </summary>
        [Key] // Tell EF Core to make this a PK
        public int StudentID { get; set; }

        /// <summary>
        /// The student's full legal name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The student's date of birth
        /// </summary>
        public DateTime DateOfBirth { get; set; }
    }
}
