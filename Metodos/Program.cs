using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = Sumar(4,6);
            Console.WriteLine("El resultado de la suma 4 + 6 es {0}", res);


            Console.WriteLine("Parametro por valor!!!");
            int numero = 20;
            Console.WriteLine("Valor de num antes del metodo {0}", numero);
            incrementar(numero);
            Console.WriteLine("Valor de num despues del metodo {0}", numero);

            Console.WriteLine("Parametro por referencia!!");
            int numero2 = 100;
            Console.WriteLine("Valor de num antes del metodo {0}", numero2);
            incrementarNumero(ref numero2);
            Console.WriteLine("Valor de num despues del metodo {0}", numero2);

            Console.ReadKey();
        }
        static void incrementar(int num)
        {
            num = num * 2;
            Console.WriteLine("Valor de num dentro del metodo {0}",num);
        }
        static void incrementarNumero(ref int num) {
            num = num * 2;
            Console.WriteLine("Valor de num dentro del metodo {0}", num);
        }
        static int Sumar(int num1, int num2) {
            return num1 + num2;
        }
    }
}
