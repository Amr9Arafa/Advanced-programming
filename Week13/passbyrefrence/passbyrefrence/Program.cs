using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace passbyrefrence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    namespace NamedOptionalParams
    {
        class Program
        {
            
            static void Main(string[] args){

                int x = 10;

                myFunction(ref x);

                Console.WriteLine("{0}",x);

                Console.ReadLine();
           
            }

             static void myFunction( ref int  y){

                 y += 10;
            
              
            }

           


        }


    }
}