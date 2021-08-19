using System;
using System.Linq;

namespace TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un proyecto de consola:
            a. Pedir al usuario la cantidad de números que desea ingresar.
            b. Crear un array del tamaño que ingresó el usuario.
            c. Cargar el array secuencialmente.
            d. Mostrar el contenido del array
            e. Informar:
            i. El número mayor y el menor.
            ii. La suma de todos los números.
            iii. El promedio.
            f. Pedir al usuario la posición de un elemento y eliminarlo.
            g. Mostrar el contenido del array.*/

            Console.WriteLine("Ingrese la cantidad de numeros que desea ingresar: ");
            int cant;
            bool IsCNum = Int32.TryParse(Console.ReadLine(), out cant);
            if (IsCNum)
            {
                int[] arr = new int[cant];
                for (int i = 0; i < arr.Length; i++)
                {
                    bool IsNum = false;
                    do
                    {
                        Console.WriteLine("Ingrese un valor numerico: ");
                        int num;
                        IsNum = Int32.TryParse(Console.ReadLine(), out num);
                        if (!IsNum)
                        {
                            Console.WriteLine("ERROR: Ingrese un valor numerico");
                        }
                        else
                        {
                            arr[i] = num;
                        }
                    } while (!IsNum);
                }

                //Mostrar arr
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }

                //Max Min
                Console.WriteLine("El numaro mayor es {0} ,y el numero menor es {1}", arr.Max(), arr.Min());

                //sumatoria
                int res = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    res += arr[i];
                }
                Console.WriteLine("La suma total del array es {0}", res);
                //Promedio
                decimal prom = res / (decimal)arr.Count();
                Console.WriteLine("El promedio del array es {0}", prom);


                //eliminar elemento
                Console.WriteLine("Digite la posicion del elemento que desea eliminar: ");
                int idx = Int32.Parse(Console.ReadLine());
                for (int i = idx; i < arr.Length-1; i++)
                {
                   arr[i] = arr[i + 1];
                   arr[arr.Length - 1] = 0;
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("Elementos del array {0}" ,arr[i]);
                }
            }
            else
            {
                Console.Write("El valor de la cantidad es incorrecta");
            }
        }
    }
}
