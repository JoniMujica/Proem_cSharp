using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_INTEGRADOR_P1
{
    class Program
    {

        /*
            2. Para el departamento de facturación:
            a. Ingresar tres precios de productos y mostrar la suma de los mismos.
            b. Ingresar tres precios de productos y mostrar el promedio de los mismos.
            c. ingresar tres precios de productos y mostrar el precio final (más IVA 21%).         
         */
        static void Main(string[] args)
        {
            double[] vec = new double[3];
            for (int i = 0; i < vec.Length; i++)
            {
                Console.WriteLine("Escriba el valor del producto {0}", i+1);
                vec[i] = double.Parse(Console.ReadLine());
            }
            MostrarVector(vec);
            Console.WriteLine("La suma total de los productos es ${0}", Sumar(vec));
            Console.WriteLine("El promedio total de los productos es {0}", Promedio(vec));
            Console.WriteLine("El precio total + IVA (21%) es: ${0}", Iva(vec));

            Console.ReadKey();
        }

        static void MostrarVector(double [] vec)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                Console.WriteLine("Precio del producto {0}: ${1}", (i+1),vec[i]);
            }
        }
        static double Sumar(double [] vec)
        {
            double res = 0;
            for (int i = 0; i < vec.Length; i++)
            {
                res += vec[i];
            }
            return res;
        }
        static double Promedio(double [] vec)
        {
            return Sumar(vec) / vec.Count();
        }

        static double Iva(double [] vec)
        {
            return Sumar(vec) + Sumar(vec) * 0.21;
        }
    }
}
