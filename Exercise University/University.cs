using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_University
{
    class University
    {
        private string name { get; set; }
        List<Course> courses = new List<Course>();
        List<Student> students = new List<Student>();
        List<StudentFile> studentsFile = new List<StudentFile>();

        /// <summary>
        /// Add some (>10) courses and some (>10) students hardcoded inside University's constructor.
        /// </summary>
        public University()
        {
            
            courses.Add(new Course("Java",5));
            courses.Add(new Course("C",5));
            courses.Add(new Course("C++",4));
            courses.Add(new Course("C#",6));
            courses.Add(new Course("SQL",3));
            courses.Add(new Course("ASP",2));
            courses.Add(new Course("Python",5));
            courses.Add(new Course("Django",4));
            courses.Add(new Course("Ruby",4));
            courses.Add(new Course("JavaScript",5));
            courses.Add(new Course("PHP",3));
            courses.Add(new Course("CSS",4));
            students.Add(new Student("Jena Fuseki"));
            students.Add(new Student("Bill Pier"));
            students.Add(new Student("Evi"));
            students.Add(new Student("Noula Kog"));
            students.Add(new Student("Takis Mar"));
            students.Add(new Student("El Mar"));
            students.Add(new Student("Johny Depp"));
            students.Add(new Student("Jena Rott"));
            students.Add(new Student("Soulis Bo"));
            students.Add(new Student("Billy Bo"));

           


        }
        /// <summary>
        /// Adds student
        /// </summary>
        /// <param name="name">student's name</param>
        public void AddStudent(string name)
        {
            bool exists = SearchStudentByName(name) != null;
            if (exists == false)
                students.Add(new Student(name));

        }
        /// <summary>
        /// search student by name
        /// </summary>
        /// <param name="name">student's name</param>
        /// <returns></returns>
        public Student SearchStudentByName(string name)
        {
            bool exists = false;
            foreach (Student st in students)
            {
                if (st.name == name)
                    return st;
            }

            return null;
        }
        /// <summary>
        /// search courses by name
        /// </summary>
        /// <param name="name">course's name</param>
        /// <returns></returns>
        public Course SearchCourseByName(string name)
        {
            bool exists = false;
            foreach (Course c in courses)
            {
                if (c.name == name)
                    return c;
            }

            return null;
        }

        /// <summary>
        /// removes student from the list
        /// </summary>
        /// <param name="student"></param>

        public void RemoveStudent(Student student)
        {
            if (students.Contains(student))
                students.Remove(student);
        }
        /// <summary>
        /// add course into the courses list
        /// </summary>
        /// <param name="course"></param>
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }
        /// <summary>
        /// removes coursefrom the list courses
        /// </summary>
        /// <param name="course"></param>
        public void RemoveCourse(Course course)
        {
            if (courses.Contains(course))
                courses.Remove(course); 
        }
        /// <summary>
        /// registers Student to course 
        /// </summary>
        /// <param name="course"></param>
        /// <param name="student"></param>
        public void RegisterStudentToCourse(string course, string student)
        {
            Course c = SearchCourseByName(course);
            Student st = SearchStudentByName(student);
            st.AddCourseToStudent(c);
            c.AddStudentToCourse(st);
        }

        public void GradeOfCourse(string aStudent,string aCourse,float aGrade)
        {
            Course c = SearchCourseByName(aCourse);
            Student st = SearchStudentByName(aStudent);
            StudentFile file1 = new StudentFile(st,aGrade);
            file1.AddCompletedCourseAndGrade(c, aGrade);
            studentsFile.Add(file1);
        }
             

    }
}
