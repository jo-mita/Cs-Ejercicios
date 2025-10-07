using System;

namespace mis_ejercicios
{
    public class Ejercicio10
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ejercicio 10 - Clasificación de ángulos");
            Console.Write("Introduce un ángulo en grados: ");
            if (!double.TryParse(Console.ReadLine(), out double angle)) {
                Console.WriteLine("Error: la entrada no es válida.");
                return;
            }

            string angleType = angle < 0 || angle > 360 ? "Fuera de rango" : angle < 90 ? "Agudo" : Math.Abs(angle - 90) < 1e-9 ? "Recto" : angle < 180 ? "Obtuso" : Math.Abs(angle - 180) < 1e-9 ? "Llano" : "Cóncavo/otro";
            Console.WriteLine(angleType);

            switch (angleType) {
                case "Agudo":
                case "Recto":
                case "Obtuso":
                case "Llano":
                    Console.WriteLine($"Observación: El ángulo es clasificado como {angleType}.");
                    break;
                default:
                    Console.WriteLine("Observación: Ángulo no estándar o fuera de rango.");
                    break;
            }
        }
    }
}