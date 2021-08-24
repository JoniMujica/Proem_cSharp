using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_INTEGRADOR
{
    class Program
    {
        /*
         1. Adivina el número (v 1.0):
            a. Al comenzar el juego generamos un número secreto del 1 al 100,
            b. Solicitaremos un número al usuario
            c. Si el número ingresado es el mismo que el número secreto se dará por
            terminado el juego con un mensaje similar a este: “Usted es un ganador!!! y
            en solo X intentos”.
            d. De no ser igual se debe informar si “falta...” para llegar al número secreto o si
            “se pasó...” del número secreto.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Adivina el número (v 1.0):");
            int rnd = 0,intentos = 1;
            Random rd = new Random();
            rnd = rd.Next(0, 100);
            //Solicitar(ref num);
            // Validar(rnd, num);
            bool iguales = false;
            Operar(ref iguales,rnd, ref intentos);

            Console.ReadKey();
        }

        static void Operar(ref bool iguales,int rd,ref int intentos)
        {
            int num = 0;
            Solicitar(ref num);
            Mostrar(ref iguales,rd,ref num, ref intentos);
        }
        static void Solicitar(ref int numIngresado)
        {
            bool conv = true;
            do
            {
                Console.WriteLine("Ingrese un valor: ");
                conv = Int32.TryParse(Console.ReadLine(),out numIngresado);
                if (conv == false)
                {
                    Console.WriteLine("ERROR: caracter invalido");
                    break;
                }
            } while (numIngresado < 0);
        }
        static bool Validar(int rd,int val)
        {
            return (rd == val) ? true : false;
        }
        static void Mostrar(ref bool iguales,int rnd,ref int num,ref int contador)
        {
            iguales = Validar(rnd, num);
            if (iguales)
            {
                Console.WriteLine("Usted es un ganador!! , intentos {0}", contador);
            }
            else
            {
                Reintentar(ref iguales, rnd, ref num, ref contador);
            }
        }

        static void Reintentar(ref bool cond, int rnd, ref int num,ref int cont)
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

        /*
        int Faltante(int rnd,int x)
        {
            return rnd - x;
        }
        int SePaso(int rnd, int x)
        {
            return x-rnd;
        }
        */
    }

}
