using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_University
{
    class Student
    {
        public string name { get; set; }
        private float mark { get; set; }
        private List<Course> CoursesOfStudent = new List<Course>();
       

        public Student(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Adds Course to student
        /// </summary>
        /// <param name="aCourse"></param>
        public void AddCourseToStudent(Course aCourse)
        {

            if (CoursesOfStudent.Count() < 5)
            {
                bool exists = false;

                foreach (Course c in CoursesOfStudent)
                {
                    if (c.name == aCourse.name)
                    {
                        Console.WriteLine($"The course {c.name} already exists");
                        exists = true;
                    }

                }
                if (exists == false)
                    CoursesOfStudent.Add(aCourse);
            }
            else
                Console.WriteLine("No more courses");

            
        }
    }
}
