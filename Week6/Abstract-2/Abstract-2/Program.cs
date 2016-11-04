using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Vehicles
    {
        double topspeed;
        int pcapacity;
        double price;
        char color;

        public double Topspeed
        {
            get { return topspeed; }
            set { topspeed = value; }
        }
        public int Pcapacity
        {
            get { return pcapacity; }
            set { pcapacity = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public char Color
        {
            get { return color; }
            set { color = value; }
        }


    }
    class Cars : Vehicles
    {
        int enginecapacity;
        bool wheel;
        string type;
        public int Enginecapacity
        {
            get { return enginecapacity; }
            set { enginecapacity = value; }
        }
        public bool Wheel
        {
            get { return wheel; }
            set { wheel = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public double Tax()
        {
            return Price * 0.1;
        }
    }
    class Boats : Vehicles
    {
        bool watertype;
        string theothertype;
        int sailingid;
        public bool Watertype
        {
            get { return watertype; }
            set { watertype = value; }
        }
        public string Theothertype
        {
            get { return theothertype; }
            set { theothertype = value; }
        }
        public int Sailingid
        {
            get { return sailingid; }
            set { sailingid = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Cars[] cars = new Cars[15];
            Boats[] boats = new Boats[10];
            for (int i = 0; i < 10; i++)
            {
                cars[i] = new Cars();
                boats[i] = new Boats();
            }
            for (int i = 10; i < 15; i++)
            {
                cars[i] = new Cars();
            }
            double min = 1e9;//1e9=10^9;
            int idx = -1;
            for (int i = 0; i < 10; i++)
            {
                /* double topspeed;
                 int pcapacity;
                 double price;
                 char color;
                 *   int enginecapacity;
                       bool wheel;
                           string type;
                 */
                Console.WriteLine("CarNumber: " + (i + 1));
                cars[i].Topspeed = double.Parse(Console.ReadLine());
                cars[i].Pcapacity = int.Parse(Console.ReadLine());
                cars[i].Price = double.Parse(Console.ReadLine());
                cars[i].Color = char.Parse(Console.ReadLine());
                cars[i].Enginecapacity = int.Parse(Console.ReadLine());
                cars[i].Wheel = bool.Parse(Console.ReadLine());
                cars[i].Type = Console.ReadLine();
                if (cars[i].Type == "MPV" && cars[i].Pcapacity >= 6 && cars[i].Color == 'r')
                {
                    if (min > cars[i].Price)
                    {
                        min = cars[i].Price;
                        idx = i;
                    }
                }
                if (idx != -1)
                    Console.WriteLine(cars[idx].Price);
                else
                {
                    Console.WriteLine("No Cars Found");

                }
                Console.WriteLine("-----------");
            }
            for (int i = 0; i < 15; i++)
            {
                /*   bool watertype;
         string theothertype;
         int sailingid;
                 */
                Console.WriteLine("BoatNumber: " + (i + 1));
                boats[i].Topspeed = double.Parse(Console.ReadLine());
                boats[i].Pcapacity = int.Parse(Console.ReadLine());
                boats[i].Price = double.Parse(Console.ReadLine());
                boats[i].Color = char.Parse(Console.ReadLine());
                boats[i].Watertype = bool.Parse(Console.ReadLine());
                boats[i].Theothertype = Console.ReadLine();
                boats[i].Sailingid = int.Parse(Console.ReadLine());
                Console.WriteLine("--------");
            }

        }
    }
}
