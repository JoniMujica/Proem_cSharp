using System;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 11");


            Console.WriteLine("Ingrese su edad: ");
            int edad = Int32.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad!!");
            }
            else if (edad >= 13 && edad <= 17)
            {
                Console.WriteLine("Es adolescente!!");
            }
            else
            {
                Console.WriteLine("Es un niño");
            }
        }
    }
}
