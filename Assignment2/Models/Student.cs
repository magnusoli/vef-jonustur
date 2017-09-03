using System;
namespace Assignment2.Models
{
    public class Student
    {
        /// <summary>
        /// Gets or sets the ssn.
        /// </summary>
        /// <value>The student's Social Security Number, f.x. 2707952269</value>
        public uint SSN { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name of the student, f.x. Jóhannes Guðmundsson</value>
		public string Name { get; set; }
    }
}
