using System;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedir 5 números e informar la suma acumulada y el promedio.
            int suma = 0;
            int contador = 0;
            while (contador <5)
            {
                Console.WriteLine("Escriba un numero: ");
                int n = Int32.Parse(Console.ReadLine());
                suma += n;
                contador++;
                Console.WriteLine("numero sumados {0}", suma);
            }
            double prom = (suma / (double)contador);
            Console.WriteLine("El promedio total es: {0}", prom);
        }
    }
}
