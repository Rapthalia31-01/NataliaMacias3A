using System;

namespace NataliaMacías3A
{
    class Programa_1
    {
        static void Main(string[] args)
        {
            int mayor = 0, num = 0;
            int numero;
            Console.WriteLine("Ingrese cantidad de numeros");
            numero = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine("Digite un valor");
                num = Int32.Parse(Console.ReadLine());

                if (i == 1)
                {
                    mayor = num;

                }
                else
                {
                    if (num > mayor)
                        mayor = num;
                }

            }
            Console.WriteLine("El numero mayor es " + mayor);
        }
    }
 }

