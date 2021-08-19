using System;

namespace TipoDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            float precio = 25.5F;
            double pesoProducto = 785.5;

            Console.WriteLine(float.MaxValue);
            Console.WriteLine(decimal.MaxValue);

            /*string rol = "admin ";
            // KEY.Trim() lo que hace es eliminar el espacio 
            Console.WriteLine(rol.Trim() == "admin");*/
            string rol = " Admin";
            string palabraSinEspacioa = rol.Trim();
            Console.WriteLine(palabraSinEspacioa.ToLower());
            Console.WriteLine();
            Console.WriteLine(rol == "admin");
            Console.WriteLine(rol == "Admin");


            string roll = " Admin";
            Console.WriteLine("==============================");
            Console.WriteLine(roll);
            string PalabraSinEspacio = rol.Trim();
            Console.WriteLine(PalabraSinEspacio);

        }
    }
}
