using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Student
    {

        private String name;
        private int age;
        private int id;
        public static int studentNumber;

        public Student(String studentName , int age ,int id)
        {
            name = studentName;
            this.age = age;
            this.id = id;
            studentNumber++;
           

        }

        public String getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public int getAge()
        {
            return age;
        }
        public void setAge(int age )
        {
            this.age = age;
        }
        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public void register()
        {
            Console.WriteLine("{0} has registered successfully",name);
        }

        public int numberOfFinishedhours(int term)
        {
            return term * 18;
        }

    

    }
}
