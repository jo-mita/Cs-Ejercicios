using System;

namespace mis_ejercicios
{
    public class Ejercicio3
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
                Console.WriteLine("Usted es mayor de edad.");
            else
                Console.WriteLine("Usted es menor de edad.");
        }
    }
}