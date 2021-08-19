using System;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 12");
            Console.WriteLine("Ingrese su edad: ");
            int edad = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escriba su estado civil: ");
            string ecivil = Console.ReadLine();
            ecivil = ecivil.Trim();
            ecivil = ecivil.ToLower();
            if ((ecivil != "soltero") && (edad < 18))
            {
                Console.WriteLine("Es muy pequeño para NO ser soltero.");
            }
        }
    }
}
