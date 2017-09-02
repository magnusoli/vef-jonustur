using System;
using System.Collections.Generic;
namespace Assignment2.Models
{
	public class Course
	{
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int ID { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
		public string Name { get; set; }
        /// <summary>
        /// Gets or sets the template identifier.
        /// </summary>
        /// <value>The template identifier.</value>
		public string TemplateID { get; set; }
        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>The start date.</value>
		public DateTime StartDate { get; set; }
        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>The end date.</value>
		public DateTime EndDate { get; set; }
        /// <summary>
        /// Gets or sets the student list.
        /// </summary>
        /// <value>The student list.</value>
		public List<Student> studentList { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Assignment2.Models.Course"/> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="name">Name.</param>
        /// <param name="templateid">Templateid.</param>
        /// <param name="startdate">Startdate.</param>
        /// <param name="enddate">Enddate.</param>
        /// <param name="studentlist">Studentlist.</param>
		public Course(int id, string name, string templateid, DateTime startdate, DateTime enddate, List<Student> studentlist)
		{
			ID = id;
			Name = name;
			TemplateID = templateid;
			StartDate = startdate;
			EndDate = enddate;
			studentList = studentlist;
		}
	}
}
