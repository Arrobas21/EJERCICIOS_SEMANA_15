using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ej4
{
    internal class productos
    {
        string[,] Productos = new string[0, 3];
        int cantidad = 0;

        public void redimensionar(int nuevotamano)
        {

            string[,] nuevoArreglo = new string[nuevotamano, 3];
            for (int i = 0; i < cantidad; i++)
            {

                for (int j = 0; j < Productos.GetLength(1); j++)
                {
                    nuevoArreglo[i, j] = Productos[i, j];


                }

            }
            Productos = nuevoArreglo;

        }

        public void registrar() 
        {

            redimensionar(cantidad + 1);
            Console.Write("\nIngrese nombre: ");
            Productos[cantidad,0] = Console.ReadLine();
            Console.Write("Ingrese precio: ");
            Productos[cantidad, 1] = Console.ReadLine();
            Console.Write("Ingrese stock: ");
            Productos[cantidad, 2] = Console.ReadLine();

            cantidad++;
            Console.WriteLine("\nProductos registrados correctamente");

        }

        public void mostrar()
        {

            if (cantidad == 0)
            {
                Console.WriteLine("No existen productos");
                return;
            }
            else
            {
                Console.WriteLine("\nPRODUCTOS REGISTRADOS: ");
                for (int i = 0; i < cantidad; i++)
                {

                    Console.WriteLine($"Producto {i + 1}:");
                    Console.WriteLine($"Nombre: {Productos[i,0]}");
                    Console.WriteLine($"Precio: {Productos[i,1]}");
                    Console.WriteLine($"Stock: {Productos[i, 2]}");
                    Console.WriteLine();


                }
                 
            }

            
        }

        public void modificar() 
        {


            Console.Write("\nIngresar número a modificar: ");
            int indice = int.Parse( Console.ReadLine() )-1;

            Console.Write("\nIngrese nuevo nombre: ");
            Productos[indice,0] = Console.ReadLine();
            Console.Write("Ingrese nuevo precio: ");
            Productos[indice, 1] = Console.ReadLine();
            Console.Write("Ingrese nuevo stock: ");
            Productos[indice, 2] = Console.ReadLine();

            Console.WriteLine("\nProducto modificado correctamente");


        }

    }
}
