using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace polymorphism
{
    class SuperHuman
    {
        public string name { get; set; }
        public int age { get; set; }

        public virtual void SuperPower()
        {
            Console.WriteLine("I AM SUPPERRRR");

        }

    }
    class Batman : SuperHuman
    {

        public override void SuperPower()
        {
            Console.WriteLine("Ana Elbat el sherrer");

        }
    }
    class Ironman : SuperHuman
    {

        public void name()
        {
            Console.WriteLine("IronMan");
        }
        public override void SuperPower()
        {
            Console.WriteLine("Ana ElIronMan eltaib");

        }
    }
    class CatWoman : SuperHuman
    {

        public override void SuperPower()
        {
            Console.WriteLine("Ana est3'far allah al3azeem");

        }
    }
    class Superman : SuperHuman
    {

        public override void SuperPower()
        {
            Console.WriteLine("Ana b3raf ateer ");

        }
    }
    class Spiderman : SuperHuman
    {

        public override void SuperPower()
        {
            Console.WriteLine("Shoft el shabaka bta3ty ");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<SuperHuman> x = new List<SuperHuman>();
            x.Add(new Spiderman());
            x.Add(new Batman());
            x.Add(new CatWoman());
            x.Add(new Superman());
            x.Add(new Ironman());
            x[1].name = "Batman";
            x[0].name = "SpiderMan";
            x[2].name = "CatWoman";
            x[3].name = "Superman";
            x[4].name = "IronMan";
            Console.WriteLine("INPUT 1 TO START:");
            while (Console.ReadLine() == "1")
            {
                string h = Console.ReadLine();
                if (h == "Bruce")
                {
                    Console.WriteLine(x[1].name);
                    x[1].SuperPower();
                    Console.WriteLine("------");
                }
                else if (h == "Stark")
                {
                    Console.WriteLine(x[4].name);
                    x[4].SuperPower();
                    Console.WriteLine("------");
                }
                else if (h == "Clark")
                {
                    Console.WriteLine(x[3].name);
                    x[3].SuperPower();
                    Console.WriteLine("------");
                }
                else if (h == "Sill")
                {
                    Console.WriteLine(x[2].name);
                    x[2].SuperPower();
                    Console.WriteLine("------");
                }
                else if (h == "Peter")
                {
                    Console.WriteLine(x[0].name);
                    x[0].SuperPower();
                    Console.WriteLine("------");
                }
                Console.WriteLine("INPUT 1 TO CONTINUE:");
            }
        }
    }

}