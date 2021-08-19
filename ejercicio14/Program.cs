using System;

namespace ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un mes: ");
            string mes = Console.ReadLine();
            mes = mes.Trim().ToLower();

            switch (mes)
            {
                case "enero":
                    Console.WriteLine("que comiences un buen año!!!!");
                    break;
                case "marzo":
                    Console.WriteLine("A clases!!!!");
                    break;
                case "julio":
                    Console.WriteLine("se vienen las vacaciones!!!.");
                    break;
                case "diciembre":
                    Console.WriteLine("Felices fiestas!!!");
                    break;
                default:
                    break;
            }
        }
    }
}
