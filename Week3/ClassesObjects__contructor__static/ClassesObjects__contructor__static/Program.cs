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
            Student s1 = new Student("Ahmed", 20, 22322);

            s1.setAge(21);

            s1.register();
           int numberOfHours= s1.numberOfFinishedhours(5);
         

           Console.WriteLine("the student whose name is {0} and his id is {1} has finished {2} hours",s1.getName(),s1.getId(),numberOfHours);
           Console.WriteLine("there are {0} in the system", Student.studentNumber);

           Console.ReadLine();
        }
    }
}
