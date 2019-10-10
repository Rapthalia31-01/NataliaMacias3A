
using System;

namespace Programa_7
{
    class Programa_7
    {
        static void Main(string[] args)
        {
           int  contador = 101;
   
            for (int i = 1; i <= 100; i++)
            {
                contador = contador - 1;
                Console.WriteLine( i + "    " +  contador );
            }
            
            Console.ReadLine();
        }
    }
}
