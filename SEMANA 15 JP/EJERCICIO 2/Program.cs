using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cant;
            Random rnd = new Random();
            Console.WriteLine("Ingrese el # de la matriz: ");
            cant = int.Parse(Console.ReadLine());

            int[,] matriz = new int[cant, cant];
            int[,] transpuesta = new int[cant, cant];

            Console.WriteLine("\nMATRIZ ORIGINAL: \n");

            for (int i = 0; i < cant; i++)
            {

                for (int j = 0; j < cant; j++)
                {
                    matriz[i, j] = rnd.Next(40,51);
                    Console.Write(matriz[i, j]+"\t");
                }
                Console.WriteLine();

            }
            Console.WriteLine("\nMATRIZ TRANSPUESTA: \n");
            for (int i = 0; i < cant; i++)
            {

                for (int j = 0; j < cant; j++)
                {
                    transpuesta[j, i] = matriz[i, j];

                }

            }
            for (int i = 0; i < cant; i++)
            {

                for (int j = 0; j < cant; j++)
                {
                    Console.Write(transpuesta[i, j]+"\t");

                }
                Console.WriteLine();

            }
            Console.ReadKey();




        }
    }
}
