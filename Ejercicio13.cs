using System;

namespace mis_ejercicios
{
    public class Ejercicio13 
    {
        public static void Ejecutar() 
        {
            Console.WriteLine("Ejercicio 13 - Verificación de año bisiesto");
            Console.Write("Introduce un año: ");
            if (!int.TryParse(Console.ReadLine(), out int year)) {
                Console.WriteLine("Error: la entrada no es válida.");
                return;
            }

            string result = year <= 0 ? "Año inválido" : (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0) ? "Bisiesto" : "No es bisiesto";
            Console.WriteLine(result);

            switch (result) {
                case "Bisiesto":
                    Console.WriteLine("Observación: Febrero tiene 29 días.");
                    break;
                case "No es bisiesto":
                    Console.WriteLine("Observación: Febrero tiene 28 días.");
                    break;
                default:
                    Console.WriteLine("Observación: Revisa el año ingresado.");
                    break;
            }
        }
    }
}