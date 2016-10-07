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
            Student s1 = new Student();
            s1.name = "Amr";
            s1.age = 24; ;
            s1.id = 10102102;

            s1.register();
           int numberOfHours= s1.numberOfFinishedhours(5);
           int studentId = s1.getStudentId();
           string studentName = s1.getStudentName();

           Console.WriteLine("the student whose name is {0} and his id is {1} has finished {2} hours",studentName,studentId,numberOfHours);

           Console.ReadLine();
        }
    }
}
