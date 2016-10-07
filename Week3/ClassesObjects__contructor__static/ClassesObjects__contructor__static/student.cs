using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Student
    {

        public String name;
        public int age;
        public int id;

        public void register()
        {
            Console.WriteLine("{0} has registered successfully",name);
        }

        public int numberOfFinishedhours(int term)
        {
            return term * 18;
        }

        public int getStudentAge()
        {
            return age;
        }

        public int getStudentId()
        {
            return id;
        }
        public String getStudentName()
        {
            return name;
        }

    }
}
