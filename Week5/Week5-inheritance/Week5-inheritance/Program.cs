using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{

    
    class Employees
    {
        protected int id;
        protected double salary;
        protected int age;
        protected string name;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }




    }
    class programmers : Employees
    {
        bool time;//if true means full time else part time
        double workinghours;
        string level;
        public bool Time
        {
            get { return time; }
            set { time = value; }
        }
        public double Workinghours
        {
            get { return workinghours; }
            set { workinghours = value; }
        }
        public string Level
        {
            get { return level; }
            set
            {
                if (!(value == "junior" || value == "mid-level" || value == "senior"))
                {

                    level = "Wrong Ans";
                }
                else

                    level = value;

            }

        }
        class designers : Employees
        {
            bool type;//if true therefore hired if flase freelancers
            string awesomelevel;//poor , good , awsome
            public bool Type
            {
                get { return type; }
                set { type = value; }
            }
            public string Awesomelevel
            {
                get { return awesomelevel; }
                set
                {
                    if (!(value == "poor" && value == "good" && value == "awesome"))
                    {
                        awesomelevel = "WRONG ANS";

                    }
                    else awesomelevel = value;
                }
            }


        }
        class Program
        {
            static void Main(string[] args)
            {
                designers[] design = new designers[3];
                for (int i = 0; i < 3; i++)
                {
                    design[i] = new designers();
                }
                programmers[] program = new programmers[3];
                for (int i = 0; i < 3; i++)
                {
                    program[i] = new programmers();
                }
                Console.WriteLine("Please enter the Info of the Designers:");
                for (int i = 0; i < 3; i++)
                {
                    design[i].Id = int.Parse(Console.ReadLine());
                    design[i].Salary = double.Parse(Console.ReadLine());
                    design[i].Age = int.Parse(Console.ReadLine());
                    design[i].Name = Console.ReadLine();
                    Console.WriteLine("Input true if hired else input Zero");
                    design[i].Type = bool.Parse(Console.ReadLine());
                    design[i].Awesomelevel = Console.ReadLine();
                    Console.WriteLine("-------");
                }

                Console.WriteLine("Please enter the Info of the Programmers:");
                int idx = -1;
                double max = 0; ;
                for (int i = 0; i < 3; i++)
                {
                    program[i].Id = int.Parse(Console.ReadLine());
                    program[i].Salary = double.Parse(Console.ReadLine());
                    program[i].Age = int.Parse(Console.ReadLine());
                    program[i].Name = Console.ReadLine();
                    Console.WriteLine("Input 1 if full time else input Zero:");
                    program[i].Time = bool.Parse(Console.ReadLine());
                    program[i].Workinghours = double.Parse(Console.ReadLine());
                    program[i].Level = Console.ReadLine();
                    if (max < program[i].Workinghours)
                    {
                        max = program[i].Workinghours;
                        idx = i;
                    }
                    Console.WriteLine("-------");
                }

                if (program[idx].Age < 24 && program[idx].Level == "junior")
                {
                    Console.WriteLine(program[idx].Name);
                    program[idx].Salary += program[idx].Salary * 0.15;
                }


            }
        }
    }
}
