using System;

namespace mis_ejercicios
{
    public class Ejercicio6 
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ejercicio 6 - Evaluación de calificaciones");
            Console.Write("Por favor, introduce la calificación (0-100): ");
            if (!double.TryParse(Console.ReadLine(), out double grade)) {
                Console.WriteLine("Error: la entrada no es válida.");
                return;
            }

            string status = (grade < 0 || grade > 100) ? "Fuera de rango" : (grade >= 60) ? "Aprobado" : "Reprobado";
            Console.WriteLine(status);

            switch (status) {
                case "Aprobado":
                    Console.WriteLine("Observación: Felicitaciones, has aprobado.");
                    break;
                case "Reprobado":
                    Console.WriteLine("Observación: Necesitas mejorar para aprobar.");
                    break;
                default:
                    Console.WriteLine("Observación: Revisa la calificación ingresada.");
                    break;
            }
        }
    }
}