using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1t3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese un número entero:");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El número ingresado es PAR.");
            }
            else
            {
                Console.WriteLine("El número ingresado es IMPAR.");
            }

            Console.WriteLine("Precione x para salir.");
            Console.ReadKey();

        }
    }
}
