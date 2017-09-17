using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadKey();//para que me lea lo ingresado por Console

            Console.WriteLine("{0,10}{1,-10}{2}", 10, 15, 23);
            
            Console.WriteLine("{0,10:#,###.00}{1,10}", 10.476, 15.355);
            Console.ReadKey();
        }
    }
}
