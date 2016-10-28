using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace week3_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Animal
    {


        public void eat()
        {
            Console.WriteLine(" eating ");
        }

        public void sleep(int hours)
        {
            Console.WriteLine("Sleeping");
        }

        public void Walk()
        {
            Console.WriteLine("walking");
        }



        public abstract void makeNoise();
   
    }


 
       class Dog : Animal
        {

        public void makeNoise()
        {
            Console.WriteLine("BARK BARK !!");
        }
        

        }

       class Cow : Animal
       {

           public void makeNoise()
           {
               Console.WriteLine("MOW MOW !!");
           }


       }

    class cat :Animal
    {

        public override void  makeNoise()
        {
 	        Console.WriteLine("MEOW MEOW !!");
        }

    }




}
