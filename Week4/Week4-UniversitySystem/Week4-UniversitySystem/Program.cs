using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

         //   Student[] students = new Student[3] { new Student("Ahmed", 20, 99883), new Student("Ahmed", 20, 99883), new Student("Ahmed", 20, 99883) };

            List<Student> studentList= new List<Student>();
            studentList.Add(new Student("Ahmed",20,99883));
            studentList.Add(new Student("Moataz", 21, 99884));
            studentList.Add(new Student("MAhmoud", 20, 99885));
            studentList.Add(new Student("Menna", 19, 99886));
            Professor professor1 = new Professor("Karim","Computer");
            Course courseCC315 = new Course(professor1,studentList, "AdvancedProgramming");
            Console.WriteLine("the professor {0} is teaching course {1}", courseCC315.getProfessorName(),courseCC315.getCourseNAme());
            Console.WriteLine("There are {0} student in this course",courseCC315.getStudentCount());
            Console.ReadLine();



        }
    }
}
