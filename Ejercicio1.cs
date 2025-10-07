using System;

namespace mis_ejercicios
{
    public class Ejercicio1
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
                Console.WriteLine("El número es positivo.");
            else if (numero < 0)
                Console.WriteLine("El número es negativo.");
            else
                Console.WriteLine("El número es cero.");
        }
    }
}
