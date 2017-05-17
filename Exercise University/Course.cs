using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_University
{
    class Course
    {
        public string name { get; set; }
        public int ect { get; set; }
        List<Student> StudentsOfCourse = new List<Student>();

        public Course(string aName, int anECT)
        {
            name = aName;
            ect = anECT;
        }

        public void AddStudentToCourse(Student aStudent)
        {
            bool exists = false;

            foreach (Student st in StudentsOfCourse)
            {
                if (st.name == aStudent.name)
                {
                    Console.WriteLine($"The student {st.name} already exists");
                    exists = true;
                }
            }
            if (exists == false)
                StudentsOfCourse.Add(aStudent);

        }


    }
}
