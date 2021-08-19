using System;

namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un mes: ");
            string mes = Console.ReadLine().Trim().ToLower();
            switch (mes)
            {
                case "febrero":
                    Console.WriteLine("Este mes no tiene mas de 29 dias!");
                    break;
                default:
                    Console.WriteLine("Este mes tiene 30 o mas dias");
                    break;
            }
        }
    }
}
