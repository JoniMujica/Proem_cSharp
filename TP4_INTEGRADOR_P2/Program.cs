using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_INTEGRADOR_P2
{
    class Program
    {
        /*
         2. Adivina el número (v 1.1):
            a. En esta oportunidad el juego evaluará tus aptitudes a partir de la cantidad de
            intentos, por lo cual se informará lo siguiente:
            i. 1° intento: “usted es un Psíquico”.
            ii. 2° intento: “excelente percepción”.
            iii. 3° intento: “Esto es suerte”.
            iv. 4° intento: “Excelente técnica”.
            v. 5° intento: “usted está en la media”.
            vi. Desde 6 Intentos hasta 10:”falta técnica”
            vii. Más de 10 intentos: “afortunado en el amor!!”.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Adivina el número (v 1.1):");
            int rnd = 0, intentos = 1;
            Random rd = new Random();
            rnd = rd.Next(0, 100);
            //Solicitar(ref num);
            // Validar(rnd, num);
            bool iguales = false;
            Operar(ref iguales, rnd, ref intentos);

            Console.ReadKey();
        }

        static void Operar(ref bool iguales, int rd, ref int intentos)
        {
            int num = 0;
            Solicitar(ref num);
            Mostrar(ref iguales, rd, ref num, ref intentos);
        }
        static void Solicitar(ref int numIngresado)
        {
            bool conv = true;
            do
            {
                Console.WriteLine("Ingrese un valor: ");
                conv = Int32.TryParse(Console.ReadLine(), out numIngresado);
                if (conv == false)
                {
                    Console.WriteLine("ERROR: caracter invalido");
                    break;
                }
            } while (numIngresado < 0);
        }
        static bool Validar(int rd, int val)
        {
            return (rd == val) ? true : false;
        }
        static void Mostrar(ref bool iguales, int rnd, ref int num, ref int contador)
        {
            iguales = Validar(rnd, num);
            if (iguales)
            {
                Console.WriteLine("Usted es un ganador!! , intentos {0}", contador);
                Casos(contador);
            }
            else
            {
                Reintentar(ref iguales, rnd, ref num, ref contador);
            }
        }

        static void Casos(int intentos)
        {
            switch (intentos)
            {
                case 1:
                    Console.WriteLine("usted es un Psíquico");
                    break;
                case 2:
                    Console.WriteLine("Excelente Percepcion");
                    break;
                case 3:
                    Console.WriteLine("Esto es suerte");
                    break;
                case 4:
                    Console.WriteLine("Excelente Tecnica");
                    break;
                case 5:
                    Console.WriteLine("Usted esta en la media");
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Falta Tecnica");
                    break;

                default:
                    Console.WriteLine("Afortunado del amor!");
                    break;
            }
        }

        static void Reintentar(ref bool cond, int rnd, ref int num, ref int cont)
        {
            while (!cond)
            {
                if (rnd > num)
                {
                    Console.WriteLine("Falta...");
                    cont++;
                    Operar(ref cond, rnd, ref cont);
                }
                else if (rnd < num)
                {
                    Console.WriteLine("se pasó....");
                    cont++;
                    Operar(ref cond, rnd, ref cont);
                }
            }
        }
    }
}
