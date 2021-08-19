using System;

namespace Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int m = 12;
            int n = 25;
            if (m>10)
            {
                if (n > 20)
                    Console.WriteLine("bloque if");
            }
            else if (m > 20)
            {
                Console.WriteLine("M ES MAYOR QUE 20");
            }
            else
            {
                Console.WriteLine("m ES MENOR QUE 20");
            }*/

            /************************************************************

            Console.WriteLine("Ingrese un caracter: ");
            char c = (char)Console.Read();

            if (Char.IsLetter(c))
            {
                Console.WriteLine("Es una letra");
            }
            else
            {
                Console.WriteLine("No es un caracter alfabetico");
            } */




            /***********************************************
            Console.WriteLine("Ingrese un caracter: ");
            char c = (char)Console.Read();

            if (Char.IsLetter(c))
            {
                if (Char.IsLower(c))
                {
                    Console.WriteLine("esta en minuscula");
                }
                else
                {
                    Console.WriteLine("esta en mayuscula");
                }
            }
            else
            {
                Console.WriteLine("No es un caracter alfabetico");
            }*/


            /*******************************************************************
            Console.WriteLine("Ingrese un caracter: ");
            char ch = (char)Console.Read();

            if (Char.IsUpper(ch))
            {
                Console.WriteLine("El caracter es una letra mayuscula");
            }
            else if (char.IsLower(ch))
            {
                Console.WriteLine("El caracter es una letra minuscula");
            }
            else if (char.IsDigit(ch))
            {
                Console.WriteLine("El caracter es un numero");
            }
            else
            {
                Console.WriteLine("el caracter no es alfanumerico");
            }

            */


            // NOT


            /*
            bool resultado = true;
            if (!resultado)
            {
                Console.WriteLine("La condicion es {0} (el resultado es falso)", resultado);
            }
            else
            {
                Console.WriteLine("La condicion es {0} (el resultado es true)", resultado);
            }*/


            ///////////////////////////////
            /*
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            if (!string.IsNullOrEmpty(nombre))
            {
                Console.WriteLine("Dato ingresado correctamente");
            }
            else
            {
                Console.WriteLine("el dato esta vacio");
            }*/



            /** AND
            int m = 9;
            int n = 7;
            int p = 5;
            if (m>=n&&m >= p)
            {
                Console.WriteLine("Nada es mas grande que M");
            }*/



            int m = 9;
            int n = 7;
            int p = 5;
            if (m >= n || m>p)
            {
                Console.WriteLine("Nada es mas grande que M");
            }
        }
    }
}


