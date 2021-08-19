using System;

namespace ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========EJERCICIO 1============");
            int variable;
            variable = 5;
            Console.WriteLine("El valor de la variable es {0}",variable);



            Console.WriteLine("=========EJERCICIO 3============");
            int variable_a, variable_b, variable_resultado;
            variable_a = 33;
            variable_b = 77;
            variable_resultado = variable_a + variable_b;
            Console.WriteLine("La suma de la variable A + B es {0}", variable_resultado);



            Console.WriteLine("=========EJERCICIO 4============");
            int a, b, c, d, e;
            Console.WriteLine("Escriba el valor de la variable A: ");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el valor de la variable B: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el valor de la variable C: ");
            c = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el valor de la variable D: ");
            d = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el valor de la variable E: ");
            e = Int32.Parse(Console.ReadLine());
            float promedio;
            promedio = (a + b + c + d + e) / 5;
            Console.WriteLine("El promedio total es {0:#,#}",promedio);
        }
    }
}
