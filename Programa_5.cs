using System;

namespace Programa_5
{
    class Programa_5
    {
        static void Main(string[] args)
        {

            int nume;
            Console.WriteLine("Ingrese un número entero para la" +
                " creación una pirámide de asteriscos: ");
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
            Console.Read();
        }
            }
            
        }
    

