using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 10");
            Console.WriteLine("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            if (!(edad >= 13 && edad <= 17))
            {
                Console.WriteLine("NO adolecente");
            }
        }
    }
}
