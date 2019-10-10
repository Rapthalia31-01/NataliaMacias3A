using System;

namespace Programa_10
{
    class Programa_10
    {
        static void Main(string[] args)
        {
            int op, nume, factorial = 1, suma = 0;
            do
            {
                Console.WriteLine("1) Salir");
                Console.WriteLine("2) Sumatorio");
                Console.WriteLine("3) Factorial");
                Console.Write("\n");
                Console.WriteLine("Ingrese la opción: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        break;

                    case 2:
                        Console.WriteLine("Ingrese un número: ");
                        nume = int.Parse(Console.ReadLine());
                        suma = nume + nume;
                        Console.WriteLine("La suma del número ingresado es: " + suma);
                        break;

                    case 3:
                        Console.WriteLine("Ingrese un número: ");
                        nume = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= nume; i++)
                        {
                            factorial = factorial * i;
                        }
                        Console.WriteLine("El factorial " + nume + " es: " + factorial);
                        break;
                }
                Console.Write("\n");
            } while (op != 1);

        }
    }
}
