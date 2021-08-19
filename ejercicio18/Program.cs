using System;

namespace ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una hora: ");
            int hora = Int32.Parse(Console.ReadLine());
            switch (hora)
            {
                case 7: case 8: case 9: case 10: case 11:
                    Console.WriteLine("Es de mañana.");
                    break;
                default:
                    break;
            }
        }
    }
}
