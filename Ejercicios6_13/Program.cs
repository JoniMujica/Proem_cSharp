using System;

namespace Ejercicios6_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            //6
            Console.WriteLine();
            Console.WriteLine("Ejercicio 6");
            if (edad == 15)
            {
                Console.WriteLine("Quinceañero / a");
            }


            //7
            Console.WriteLine();
            Console.WriteLine("Ejercicio 7");
            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
            }


            //8
            Console.WriteLine();
            Console.WriteLine("Ejercicio 8");
            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("Es menor de edad");
            }


            //9
            Console.WriteLine();
            Console.WriteLine("Ejercicio 9");
            if (edad >= 13 && edad <= 17)
            {
                Console.WriteLine("Es adolecente");
            }


            //10
            Console.WriteLine();
            Console.WriteLine("Ejercicio 10");
            if (!(edad >= 13 && edad <= 17))
            {
                Console.WriteLine("NO adolecente");
            }


            //11
            Console.WriteLine();
            Console.WriteLine("Ejercicio 11");
            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad!!");
            }
            else if (edad >= 13 && edad <= 17)
            {
                Console.WriteLine("Es adolescente!!");
            }
            else
            {
                Console.WriteLine("Es un niño");
            }



            //12
            Console.WriteLine();
            Console.WriteLine("Ejercicio 12");
            Console.WriteLine("Escriba su estado civil: ");
            string ecivil = Console.ReadLine();
            ecivil = ecivil.Trim();
            ecivil = ecivil.ToLower();
            if ((ecivil == "soltero") && (edad < 18))
            {
                Console.WriteLine("Es muy pequeño para NO ser soltero.");
            }

            //13
            Console.WriteLine();
            Console.WriteLine("Ejercicio 13");
            if ((ecivil == "soltero") && (edad > 18))
            {
                Console.WriteLine("Es soltero y no es menor");
            }
        }
    }
}
