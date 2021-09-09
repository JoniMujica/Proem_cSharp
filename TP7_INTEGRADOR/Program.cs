using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7_INTEGRADOR
{
    class Program
    {
        /*1. Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que
        el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR.
        ¡Reingresar número!". Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la
        operación.*/
        static void Main(string[] args)
        {
            
            double a;
            do
            {
                Console.WriteLine("Digite un numero: ");
                while (!Double.TryParse(Console.ReadLine(),out a))
                {
                    Console.WriteLine("ERROR: el digito ingresado es invalido, por favor ingrese un valor numerico: ");
                }
                //a > 0 ? Cuadrado(ref a) : Console.WriteLine("ERROR: Dijite un numero mayor a cero:");
                Console.WriteLine("{0}", a>0? $"El cuadrado del numero  {a} es {Cuadrado(a)}" : "ERROR. ¡Reingresar número!");

            } while (a<=0);
            Console.ReadKey();
        }

        static double Cuadrado(double num) {

            return Math.Pow(num, 2);
        }
    }
}
