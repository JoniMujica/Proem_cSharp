using System;

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 13");



            Console.WriteLine("Ingrese su edad: ");
            int edad = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escriba su estado civil: ");
            string ecivil = Console.ReadLine();
            ecivil = ecivil.Trim();
            ecivil = ecivil.ToLower();
            if ((ecivil == "soltero") && (edad >= 18))
            {
                Console.WriteLine("Es soltero y no es menor");
            }
        }
    }
}
