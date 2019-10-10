using System;

namespace Programa_6
{
    class Programa_6
    {
        static void Main(string[] args)
        {
            int nume;
            Console.WriteLine("Ingrese un número entero: ");
            nume = int.Parse(Console.ReadLine());
            for (int i = 0; i < nume + 1; i++)
            {

                for (int j = 0; j < nume - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            for (int i = 0; i < nume + 1; i++)
            {

                for (int j = 0; j < i+1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < ((nume-i-1)*2)-1; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
