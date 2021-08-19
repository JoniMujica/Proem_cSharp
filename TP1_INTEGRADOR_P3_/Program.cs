using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_INTEGRADOR_P3_
{
    class Program
    {

        /*
         Para el departamento de Pinturas:
            a. Al ingresar una temperatura en Fahrenheit debemos mostrar la temperatura
            en Centígrados con un mensaje concatenado (ej.: " 32 Fahrenheit son 0
            centígrados").
            b. Al ingresar una temperatura en Centígrados debemos mostrar la temperatura
            en Fahrenheit (ej.: "0 centígrados son 32 Fahrenheit ").
         */
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese la temperatura en Fahrenheit: ");
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la temperatura en Centígrados: ");
            double c = double.Parse(Console.ReadLine());

            Mostrar(f, c);
            Console.ReadKey();
        }
        static void Mostrar(double f, double c) {

            Console.WriteLine("{0} Fahrenheit son: {1}°C ", f,FaC(f));
            Console.WriteLine("{0} centígrados son: {1}°F ", c, CaF(c));
        }
        static double FaC(double x) {

            return (x - 32.0) * (5.0 / 9.0);
        }
        static double CaF(double x) {
            return (9.0 / 5.0) * x + 32.0;
        }
    }
}
