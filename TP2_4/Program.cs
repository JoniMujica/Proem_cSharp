using System;

namespace TP2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("El numero {0} es divisible por 3", i);
                }
                else
                {
                    Console.WriteLine("{0} no es divisible por 3", i);
                }
            }
        }
    }
}
