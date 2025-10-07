using System;

namespace mis_ejercicios
{
    public class Ejercicio5
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ejercicio 5 - Evaluación de descuentos por edad");
            Console.Write("Introduce tu edad: ");
            if (!int.TryParse(Console.ReadLine(), out int age)) {
                Console.WriteLine("Error: la entrada no es válida.");
                return;
            }

            bool qualifiesForDiscount = age > 60;
            Console.WriteLine(qualifiesForDiscount ? "Tienes un descuento del 50%" : "No tienes descuento");

            switch (qualifiesForDiscount) {
                case true:
                    Console.WriteLine("Observación: Aplica un descuento del 50%.");
                    break;
                case false:
                    Console.WriteLine("Observación: Precio normal.");
                    break;
            }
        }
    }
}