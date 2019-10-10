/***
 * Crear un programa para calcular el salario semanal de unos empleados a los que se les paga 15 dólares
por hora si éstas no superan las 35 horas. Cada hora por encima de 35 se considerará extra y se paga a
22 dólares.
El programa pide las horas del trabajador y devuelve el salario que se le debe pagar
Además, el programa debe preguntar si deseamos calcular otro salario, si es así el programa se repite.
 */

using System;


namespace Programa_4
{
    class Programa_4
    {
        static void Main(string[] args)
        {
            int horas = 15, salario = 0, horas_extra;
            string Salario_2 = "si";
            do
            {
                Console.Write("\n");
                Console.WriteLine("Ingrese horas a trabajar: ");
                int Horas_cant = int.Parse(Console.ReadLine());
                if (horas > 35)
                {
                    salario = horas * 35;
                    horas = 22;
                    Horas_cant = Horas_cant - 35;
                    horas_extra = horas * Horas_cant;
                    salario = salario + horas_extra;
                }
                else
                {
                    salario = horas * Horas_cant;
                }
                Console.WriteLine("El salario semanal a cobrar es: " + salario);
                Console.Write("\n");

                Console.WriteLine("¿Desea calcular otro salario? Responda  si o no");
                Salario_2 = Console.ReadLine();

            } while (Salario_2 == "si");


        }
    }
}
