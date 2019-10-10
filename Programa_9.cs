///Crear el programa tablaMultiplicar que escriba la tabla de multiplicar del número 1 al número 15
using System;

namespace Programa_9
{
    class Programa_9
    {
        static void Main(string[] args)
        {
            int numero;

            for (int i = 1; i <=15; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Console.WriteLine("{0}x{1}={2}", i, j,  i * j );;
                }
                Console.WriteLine();
               
            }
           
            }
    }
}
