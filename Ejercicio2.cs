using System;

namespace mis_ejercicios
{
    public class Ejercicio2
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("El número es par.");
            else
                Console.WriteLine("El número es impar.");
        }
    }
}
