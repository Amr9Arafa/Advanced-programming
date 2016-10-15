using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Professor
    {
        private string name;
        private string department;

        public Professor(string name , string departmentName)
        {
            this.name = name;
            department = departmentName;
        }

        public string getProfessorNAme()
        {
            return name;
        }

    }
}
