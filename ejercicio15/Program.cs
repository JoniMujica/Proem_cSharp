using System;

namespace ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un mes: ");
            string mes = Console.ReadLine().Trim().ToLower();
            switch (mes)
            {
                case "julio":
                case "agosto":
                    Console.WriteLine("Abrigate que hace frio!!!");
                    break;
                case "enero":
                case "febrero":
                case "marzo":
                case "abril":
                case "mayo":
                case "junio":
                    Console.WriteLine("Falta para el invierno!!");
                    break;
                case "septiembre":
                case "octubre":
                case "noviembre":
                case "diciembre":
                    Console.WriteLine("ya pasamos el frio, ahora calor!!!");
                    break;
                default:
                    break;
            }

        }
    }
}
