using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Course
    {
        Professor mProfessor;
        List<Student> students;
        string courseName;
        

        public Course(Professor professor, List<Student> studentArr,string name)
        {
            mProfessor = professor;
            students = studentArr;
            courseName = name;
        }

       public int  getStudentCount(){
           return students.ToArray().Length;
       }

       public string getProfessorName(){
           return mProfessor.getProfessorNAme();
       }


       public bool checkIfStudentIsRegisterd(string name)
       {
           for (int i = 0; i < students.ToArray().Length; i++)
           {
               if (students[i].getName().Equals(name))
               {
                return true;
               }
              
           }
            return false;
       }

       public String getCourseNAme()
       {
           return courseName;
       }


 



    }
}
