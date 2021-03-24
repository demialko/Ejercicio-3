using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string tecla = "";
            Console.WriteLine("Para finalizar el proceso se debe presionar la tecla X");
            do
            {
                tecla = Console.ReadLine().ToUpper();
                if (tecla != "X")
                {
                    Console.WriteLine("Se debe ingresar la tecla X para finalizar el proceso, usted ha ingresado la tecla " + tecla);
                }
            } while (tecla != "X");
            Console.WriteLine("El proceso ha finalizado con exito");

            Console.ReadKey();
        }
    }
}
