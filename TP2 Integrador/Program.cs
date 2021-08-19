using System;

namespace TP2_Integrador
{
    class Program
    {
        static void Main(string[] args)
        {
            string F = "Fizz";
            string B = "Buzz";
            for (int i = 1; i <= 100; i++)
            {
                if (i%3==0 && i%5==0)
                {
                    Console.WriteLine("{0} - {1}{2}",i,F,B);
                }
                else if (i%3 == 0)
                {
                    Console.WriteLine("{0} - {1}", i,F);
                }
                else if (i%5 == 0)
                {
                    Console.WriteLine("{0} - {1}",i, B);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
