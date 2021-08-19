using System;

namespace TP1_integrador
{
    class Program
    {
        static void Main(string[] args)
        {

            //Usar la clase Random para generar un valor. 
           // Según el valor utilizar el operador condicional para mostrar “Cara” o “Cruz”. Debe haber un 50 % de probabilidad que el resultado sea cara o cruz.
            Random rd = new Random();
            int val = rd.Next(0,100);

            Console.WriteLine("{0},el valor es {1}", (val > 50 ? "Cara":"Cruz"),val);
        }
    }
}
