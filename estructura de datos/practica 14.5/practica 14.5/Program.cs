using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_14._5
{
    internal class Program
    {
        static void Main()
        {
            int[] califMateria = new int[5];

            
            for (int i = 0; i < califMateria.Length; i++)
            {
                califMateria[i] = 0;
            }

            Console.WriteLine("Valores del arreglo:");
            foreach (int calif in califMateria)
            {
                Console.WriteLine(calif);
            }

            Console.ReadKey();
        }


    }
}
