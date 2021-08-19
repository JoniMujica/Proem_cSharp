using System;

namespace ejercicio17
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
                    Console.WriteLine("Este mes tiene 28 dias!!");
                    break;

                case "abril":
                case "junio":
                case "septimbre":
                case "noviembre":
                    Console.WriteLine("Este mes tiene 30 dias!!");
                    break;

                case "enero":
                case "marzo":
                case "mayo":
                case "julio":
                case "agosto":
                case "octubre":
                case "diciembre":
                    Console.WriteLine("Este mes tiene 31 dias!!");
                    break;
                default:
                    Console.WriteLine("No es un mes valido");
                    break;
            }
        }
    }
}
