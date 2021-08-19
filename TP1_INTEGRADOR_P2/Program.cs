using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_INTEGRADOR_P2
{
    class Program
    {
        /*
         3. Para el departamento de Construcción:
            a. Mostrar la cantidad de alambre a comprar si se ingresara el largo y el ancho
            de un terreno rectangular y se debe alambrar con tres hilos de alambre.
            b. Mostrar la cantidad de alambre a comprar si se ingresara el radio de un
            terreno circular y se debe alambrar con tres hilos de alambre.
            c. Para hacer un contrapiso de 1m x 1m se necesitan 2 bolsas de cemento y 3
            de cal, debemos mostrar cuántas bolsas se necesitan de cada uno para las
            medidas que nos ingresen.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el ancho del terreno: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el largo del terreno: ");
            double l = double.Parse(Console.ReadLine());

            Console.WriteLine("Se debe comprar {0}m de alambre para alambrar con 3 hilos", CantidadA(a,l));

            Console.ReadKey();
        }

        static double CantidadA(double a,double l)
        {
            return  (2 * a + 2 * l) * 3;
        }
    }
}
