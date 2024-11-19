using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_15_JP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f, c;
            Random rnd = new Random();
            Console.Write("Ingrese la cantidad de filas: ");
            f = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de columnas: ");
            c = int.Parse(Console.ReadLine());

            int[,] matriz = new int[f,c];

            for (int i = 0; i < f; i++) //FILAS
            { 
            
                for (int j = 0; j < c; j++) //COLUMNAS
                {
                    matriz[i, j] = rnd.Next(30,51);
                    Console.Write(matriz[i, j]+"\t");

                }
                Console.WriteLine();
            
            }
            Console.ReadKey();
        }
    }
}
