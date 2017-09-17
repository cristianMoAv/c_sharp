using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro01
{
    class Program
    {
        int auxiliarInt;
        int max; 
        int min;
        int accumulator;

        static void Main(string[] args)
        {
            Console.WriteLine("INGRESE UN NÚMERO: ");
            while(!int.TryParse(Console.ReadLine(), out auxiliarInt))
            {
                Console.WriteLine("ERROR, INGRESAR SOLO VALORES NUMÉRICOS ENTEROS");
            }
            max = auxiliarInt;
            min = auxiliarInt;
            accumulator = auxiliarInt; 
             
            for (int i= 0; i<4; i++)
            {
                Console.WriteLine("INGRESE UN NÚMERO: ");

                while (!int.TryParse(Console.ReadLine(), out auxiliarInt))
                {
                    Console.WriteLine("ERROR, INGRESAR SOLO VALORES NUMÉRICOS ENTEROS");
                }
                accumulator += auxiliarInt;

                if (auxiliarInt > max)
                {
                    max = auxiliarInt;
                }
                if(auxiliarInt < min)
                {
                    min = auxiliarInt;
                }
            }

            Console.WriteLine("El valor máximo es {0}, el minimo {1} y el promedio {2}", max, min, accumulator/5);

            Console.ReadKey();
            Console.Clear();
        }
    }
}
