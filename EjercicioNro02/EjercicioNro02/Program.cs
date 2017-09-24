using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro02
{
    class Program
    {
        static void Main(string[] args)
        {
            float number; 
            double risedNumberOne, risedNumberTwo;
            
            Console.WriteLine("Please type a number: ");

            while(!float.TryParse(Console.ReadLine(),out number))
            {
                Console.WriteLine("ERRROR, ONLY TYPE A NUMBER");
            }
            while (number <= 0)
            {
                Console.WriteLine("ERRROR, THE NUMBER MUST BE MAYOR THAN 0, ENTRY A NEW NUMBER: ");

                while (!float.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("ERRROR, ONLY TYPE A NUMBER");
                }
            }
            risedNumberOne = Math.Pow((double)number, 2);
            risedNumberTwo = Math.Pow((double)number, 3);

            Console.WriteLine("Elevate the number {0}. \nTo the squared is: {1}\nTo the third is {2}", number, risedNumberOne, risedNumberTwo);

            Console.ReadKey();            
        }
    }
}
