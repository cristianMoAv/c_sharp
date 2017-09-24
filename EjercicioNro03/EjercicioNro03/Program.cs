using System
    ;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro03
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber, isPrime;
            int i, j;

            Console.WriteLine("Please enter a whole number equal or bigger than two: ");

            while (!int.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.WriteLine("Please enter only whole numbers: ");
            }

            if (inputNumber >= 2)
            {
                for(i = 2; i <= inputNumber; i++)
                {
                    isPrime = 0;
                    for(j = 2; j <= i/2; j++)
                    {
                        if(i % j == 0)
                        {
                            isPrime = 1;
                            break;
                        }
                    }
                    if(isPrime == 0 && inputNumber != 1)
                    {
                        Console.WriteLine("\n{0} ", i);
                    }
                }

                Console.WriteLine("\n{0}", inputNumber);
            }
            else
            {
                Console.WriteLine("You don't type a whole number equal or bigger than two (2)");
            }

            Console.ReadKey();

        }
    }
}
