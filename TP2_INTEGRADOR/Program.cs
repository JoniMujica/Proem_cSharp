using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_INTEGRADOR
{
    class Program
    {

        /*
         
         
        1. Para el departamento de iluminación:
        Tomando en cuenta que todas las lámparas están en oferta al mismo precio de $35
        pesos final.

            a. Si compra 6 o más lamparitas bajo consumo tiene un descuento del 50%.
            b. Si compra 5 lamparitas bajo consumo marca "ArgentinaLuz" se hace un
            descuento del 40 % y si es de otra marca el descuento es del 30%.
            c. Si compra 4 lamparitas bajo consumo marca "ArgentinaLuz" o
            “FelipeLamparas” se hace un descuento del 25 % y si es de otra marca el
            descuento es del 20%.
            d. Si compra 3 lamparitas bajo consumo marca "ArgentinaLuz" el descuento es
            del 15%, si es “FelipeLamparas” se hace un descuento del 10 % y si es de
            otra marca un 5%.
            e. Si el importe final con descuento suma más de $120 se debe sumar un 10%
            de ingresos brutos en informar del impuesto con el siguiente mensaje:
            ”Usted pagó X de IIBB.”, siendo X el impuesto que se pagó.
         */

        const double precio = 35;
        static void Main(string[] args)
        {
            string[] Marca = new string[] { "ArgentinaLuz", "FelipeLamparas", "Otras" };
            Console.WriteLine("Escriba la cantidad de lamparitas que desea comprar: ");
            int cantidad = Int32.Parse(Console.ReadLine());
            int opcion = DibujarMenu(Marca);

            double res = 0;
            Operar(cantidad, opcion, ref res);

            Mostrar(Marca, opcion, cantidad, res);
            

            Console.ReadKey();
        }
        static void Mostrar(string [] vec,int op,int cant, double res)
        {
            Console.WriteLine("Se compro {0} de marca {1}, con un precio de ${2}",cant,vec[op], res);
            if (res >= 120)
            {
                res = res * 0.10;
                Console.WriteLine("Usted pagó {0} de IIBB",res);
            }
        }
        static void Operar(int cant, int op, ref double res)
        {
            if (cant >= 6 && op == 2)
            {
                res = cant * precio - cant * precio * 0.50;
            }
            else if (cant == 5 && op == 0)
            {
                res = cant * precio - cant * precio * 0.40;
            }
            else if (cant == 5 && op == 2)
            {
                res = cant * precio - cant * precio * 0.30;
            }
            else if (cant == 4 && (op == 0 || op == 1))
            {
                res = cant * precio - cant * precio * 0.25;
            }
            else if (cant == 4 && op == 2)
            {
                res = cant * precio - cant * precio * 0.20;
            }
            else if (cant == 3 && op == 0)
            {
                res = cant * precio - cant * precio * 0.15;
            }
            else if (cant == 3 && op == 1)
            {
                res = cant * precio - cant * precio * 0.10;
            }
            else if (cant == 3 && op == 2)
            {
                res = cant * precio - cant * precio * 0.05;
            }
        }
        static int DibujarMenu(string[] Marca)
        {
            Console.Clear();
            Console.WriteLine("*****************************");
            Console.WriteLine("Seleccione la marca que desea comprar ");
            Console.WriteLine("*****************************");
            for (int i = 0; i < Marca.Length; i++)
            {
                Console.WriteLine((i + 1) + "-" + Marca[i]);
            }

            int op = 0;
            bool pudoConvertir = Int32.TryParse(Console.ReadLine(), out op); 
            if (pudoConvertir == false || op >= 3)
            {
                op = 0;
            }
            return (op - 1);

        }
    }
}
