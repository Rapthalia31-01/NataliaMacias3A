using System;

namespace Programa_2
{
    class Programa_2
    {
        static void Main(string[] args)
        {
            int valor;
            Console.WriteLine("Ingrese un número entero: ");
            valor = int.Parse(Console.ReadLine());
            for (int i = 0; i < valor; i++)
            {
                for (int j = 0; j < valor; j++)
                {
                    if (i == 0 || i == valor - 1)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        if (j == 0 || j == valor - 1)
                        {
                            Console.Write(" * ");
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }
                }
                Console.Write("\n");
            }
            Console.Read();
        }

    }
 }

