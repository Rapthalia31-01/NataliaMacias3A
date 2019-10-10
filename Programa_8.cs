using System;

namespace Programa_8
{
    class Programa_8
    {
        static void Main(string[] args)
        {
            int num_seg=0, num_terc=0, i=0;
            Console.WriteLine("Ingrese un número entero: ");
           int num_pri = Int32.Parse(Console.ReadLine());
            if (num_pri > 0)
            {
                while (i < num_pri)
                {
                    
                    num_seg = num_seg + 2;
                    num_terc = num_terc + 3;
                    i++;
                    Console.WriteLine(i + "" + num_seg + "" + num_terc);

                }
            }
            else
            {
                Console.WriteLine("El número ingresado es incorrecto");
            }
                
                }
            }
        }
    

