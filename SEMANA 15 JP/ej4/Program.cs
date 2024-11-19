using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regresar;
            productos p = new productos();
            do
            {
                Console.WriteLine("1.Registrar: ");
                Console.WriteLine("2.Mostrar: ");
                Console.WriteLine("3.Modificar: ");
                Console.WriteLine("0.Salir: ");

                Console.WriteLine("Ingrese opcion: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 0: break;
                    case 1: p.registrar(); break;
                    case 2: p.mostrar(); break;
                    case 3: p.modificar(); break;

                }
                Console.WriteLine("Desea regresar al menú? [si]: ");
                regresar = Console.ReadLine();
                Console.Clear();

            } while (regresar == "si");
        }
    }
}
