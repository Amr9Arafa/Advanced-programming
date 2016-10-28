using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overloading
{
    class Product
    {
        public int Year;
        public string Name;
        public decimal price;



        public Product(string s)
        {
            Name = s;
        }
        public Product(string s, int y)
        {
            Name = s;
            Year = y;
        }
        public Product(string s, decimal p, int y)
        {
            Name = s;
            price = p;
            Year = y;
        }

        public void clean(string s1)
        {
            Console.WriteLine("This is clean method with only 1 parameter");
        }

        public void clean(string s1, string s2)
        {
            Console.WriteLine("This is clean method with only 2 parameter");
        }
        public void clean(string s1 ,string s2 ,string s3)
        {
            Console.WriteLine("This is clean method with only 3 parameter");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("Shampoo");
            Product p2 = new Product("Deodrant", 2004);
            Product p3 = new Product("Soap", 120.00m, 1994);

            Console.WriteLine("{0}", p1.Name);
            Console.WriteLine("{0} {1}", p2.Year, p2.Name);
            Console.WriteLine("{0} {1} {2}", p3.Year, p3.Name, p3.price);


            p1.clean("");
            p1.clean("","");
            p1.clean("","","");

            Console.ReadLine();
        }
    }
}
