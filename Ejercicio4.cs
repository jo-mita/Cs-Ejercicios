using System;

namespace mis_ejercicios
{
    public class Ejercicio4
    {
         public static void Ejecutar()
        {
            Console.WriteLine("Ejercicio 4 - Verificación de múltiplos de 5");
            Console.Write("Introduce un número: ");
            if (!double.TryParse(Console.ReadLine(), out double number)) {
                Console.WriteLine("Error: la entrada no es válida.");
                return;
            }

            string result = (number % 5 == 0) ? "Es múltiplo de 5" : "No es múltiplo de 5";
            Console.WriteLine(result);

            switch (result) {
                case "Es múltiplo de 5":
                    Console.WriteLine("Observación: Este número termina en 0 o 5 si es entero.");
                    break;
                default:
                    Console.WriteLine("Observación: Este número no termina en 0 o 5.");
                    break;
            }
        }
    }
}