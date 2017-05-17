using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_University
{
    class Program
    {
        static void Main(string[] args)
        {
            
            University uni = new University();
            Console.WriteLine("Give your name");

            string name = Console.ReadLine();
            uni.RegisterStudentToCourse("Java", name);
            uni.GradeOfCourse(name,"Java", 7.5F);


            Console.ReadKey();
        }
    }
}
