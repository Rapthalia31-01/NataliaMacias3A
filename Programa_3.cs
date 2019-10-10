using System;

namespace Programa_3
{
    class Programa_3
    {
        static void Main(string[] args)
        {
            int num;

            double total = 0, precio;
            do
            {
                do
                {
                    Console.WriteLine("Ingrese la cantidad vendida: ");
                    num = Int32.Parse(Console.ReadLine());
                    if (num < 0)
                    {
                        Console.WriteLine("La cantidad ingresada no es valida  ");
                    }

                    } while (num < 0) ;
                    if (num > 0)
                    {
                        Console.WriteLine("Ingrese el precio : ");
                        do
                        {
                            precio = Convert.ToDouble(Console.ReadLine());
                            if (precio < 0)
                            {
                                Console.WriteLine("El precio registrado no es valido");
                            }
                            else
                            {
                                total = precio * num;
                            }
                        } while (precio < 0);

                    }
                } while (num != 0);
            Console.WriteLine("La cantidad vendida es: " + total);
            
       }
            
    }
}
    

