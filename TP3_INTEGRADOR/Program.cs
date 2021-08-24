using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_INTEGRADOR
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Se pedirá un número positivo y se mostrará la cantidad de números pares desde el
            número ingresado hasta el cero.
            2. Se pedirá un número positivo y se mostrará la cantidad de números impares desde
            el número ingresado hasta el cero.
            3. Se pedirá un número positivo y se mostrará la cantidad de números divisibles de
            este número que se encuentran desde el 1 al 100.
            4. Se pedirá un número positivo y se mostrará si el número es un número primo o no.
            5. Se pedirá un número positivo y se mostrará la cantidad de números primos desde el
            número ingresado hasta el cero.*/
            int n = 0, pares = 0, impares = 0, div = 0, cPrimos = 0;
            do
            {
                Console.WriteLine("Ingrese un numero positivo entero: ");
                bool p = Int32.TryParse(Console.ReadLine(), out n);
                if (p == false)
                {
                    Console.WriteLine("error: valor invalido");
                    break;
                }
                else if (p == true && n >= 0)
                {
                    pares = CNumerosPares(n);
                    impares = CNumerosImares(n);
                    div = Divisible(n);
                    cPrimos = CPrimos(n);
                    Mostrar(n, pares, impares, div, cPrimos);
                }
            } while (n < 0);

            Console.ReadKey();
        }

        static void Mostrar(int n, int p, int ip, int div, int cp)
        {
            Console.WriteLine("Cantidad de numeros pares desde {0} a 0 es: {1}", n, p);
            Console.WriteLine("Cantidad de numeros impares desde {0} a 0 es: {1}", n, ip);
            Console.WriteLine("Cantidad de numeros Divisibles a {0}, desde 1 a 100: {1}", n, div);
            Console.WriteLine("El numero {0} , {1}", n, EsPrimo(n) ? "Es primo" : " No es primo");
            Console.WriteLine("Cantidad de numeros Primos desde 0 hasta {0} es: {1}", n, cp);
        }
        static int CNumerosPares(int x)
        {

            int c = 0;
            for (int i = x; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    c++;
                }
            }
            return c;
        }

        static int CNumerosImares(int x)
        {

            int c = 0;
            for (int i = x; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    c++;
                }
            }
            return c;
        }
        static int Divisible(int x)
        {
            int c = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % x == 0)
                {
                    c++;
                    Console.WriteLine("{0} es divisible por {1}", i , x);
                }
            }
            return c;
        }

        static bool EsPrimo(int x)
        {
            if (x <= 1) 
                return false; //Si es X<=1 , no es primo

            for (int i = 2; i < x; i++)
            {
                if (x % i == 0) //evalua los divisores de X, desde 2 hasta X-1
                {
                    return false;
                }
            }
            return true;
        }
        static int CPrimos(int x)
        {
            int c = 0;
            for (int i = x; i > 0; i--)
            {
                if (EsPrimo(i))
                {
                    c++;
                }
            }
            return c;
        }
    }
}