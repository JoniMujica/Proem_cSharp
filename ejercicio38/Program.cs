using System;

namespace ejercicio38
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vec = new int[10];

            
            for (int i = 0; i < vec.Length; i++)
            {
                Random rd = new Random();
                int val = rd.Next(0, 100);
                vec[i] = val;
            }

            for (int i = 0; i < vec.Length; i++)
            {
                Console.WriteLine(vec[i]);
            }
        }
    }
}
