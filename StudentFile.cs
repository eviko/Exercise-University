using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_University
{
    class StudentFile
    {
        Student student { get; set; }
        Course course { get; set; }
        float grade { get; set; }
        public StudentFile(Student aStudent, float aGrade)
        {
            student = aStudent;
            grade = aGrade;   
        }
        /// <summary>
        /// Adds the completed course and grade
        /// </summary>
        /// <param name="aCourse"></param>
        /// <param name="aGrade"></param>
        public void AddCompletedCourseAndGrade(Course aCourse,float aGrade)
        {
            Console.WriteLine($"If {aCourse.name} is completed press 1");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num==1)
            {
                course = aCourse;
                Console.WriteLine($"The student {student.name} has completed the course {aCourse.name} and the grade is {aGrade}");
                grade = float.Parse(Console.ReadLine());              
            }
        }
    }
}
