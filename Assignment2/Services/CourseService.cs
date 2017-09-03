using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Assignment2.Models;
using Assignment2.Repositories;

namespace Assignment2.Services
{
    public class CourseService
    {
        private List<Course> courseList;
        public CourseService()
        {
            courseList = Repositories.EmptyClass();
        }
		[HttpGet]
		public List<Course> Get()
		{
            return new List<Course>();
		}

		[HttpGet]
		[Route("{id}", Name = "GetCourse")]
		public IActionResult getCourse(int id)
		{
			if (courseList.Exists(element => element.ID == id))
			{
				return Json(courseList[id - 1]);
			}
			else
			{
				return NotFound();
			}
		}

		[HttpGet]
		[Route("{id}/students")]
		public IActionResult getCourseStudents(int id)
		{
			if (courseList.Exists(element => element.ID == id))
			{
				return Json(courseList[id - 1].studentList);
			}
			else
			{
				return NotFound();
			}
		}

		[HttpPost]
		[Route("post")]
		public IActionResult post([FromBody] Course course)
		{
			courseList.Add(course);
			var location = Url.Link("GetCourse", new { id = course.ID });
			return Created(location, course);
		}

		[HttpPut]
		[Route("{id}/put")]
		public IActionResult updateCourse([FromBody] Course update, int id)
		{
			if (courseList.Exists(element => element.ID == id))
			{
				String borked = "bad input for whatever reason";
				if (update.Name == borked)
				{
					return BadRequest();
				}
				courseList.RemoveAt(id - 1);
				courseList.Insert(id - 1, update);
				return NoContent();
			}
			else
			{
				return NotFound();
			}
		}

		[HttpPatch]
		[Route("{id}/patch")]
		public IActionResult addStudentToCourse(int id, [FromBody] Student newbie)
		{
			if (courseList.Exists(element => element.ID == id))
			{
				String borked = "bad input for whatever reason";
				if (newbie.Name == borked)
				{
					return BadRequest();
				}
				courseList[id - 1].studentList.Add(newbie);
				return NoContent();
			}
			else
			{
				return NotFound();
			}
		}


		[HttpDelete]
		[Route("{id}/delete")]
		public IActionResult delete(int id)
		{
			if (courseList.Exists(element => element.ID == id))
			{
				courseList.RemoveAt(id - 1);
				return NoContent();
			}
			else
			{
				return NotFound();
			}
		}
    }
}
