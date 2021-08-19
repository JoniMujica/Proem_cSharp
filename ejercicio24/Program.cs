using System;

namespace ejercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            string clave = Console.ReadLine();
            do
            {
                Console.WriteLine("Escriba la clave: ");
                clave = Console.ReadLine().Trim().ToUpper();
            } while (clave != ".NET");
        }
    }
}
