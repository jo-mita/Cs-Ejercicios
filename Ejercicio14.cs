using System;

namespace mis_ejercicios
{
    public class Ejercicio14 
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ejercicio 14 - Conversión de calificaciones");
            Console.Write("Introduce la calificación (0-100): ");
            if (!int.TryParse(Console.ReadLine(), out int grade)) {
                Console.WriteLine("Error: la entrada no es válida.");
                return;
            }

            string letterGrade = grade < 0 || grade > 100 ? "Fuera de rango" : grade >= 90 ? "A" : grade >= 80 ? "B" : grade >= 70 ? "C" : grade >= 60 ? "D" : "F";
            Console.WriteLine("Letra: " + letterGrade);

            switch (letterGrade) {
                case "A":
                    Console.WriteLine("Observación: Excelente.");
                    break;
                case "B":
                    Console.WriteLine("Observación: Muy bien.");
                    break;
                case "C":
                    Console.WriteLine("Observación: Bien.");
                    break;
                case "D":
                    Console.WriteLine("Observación: Regular.");
                    break;
                case "F":
                    Console.WriteLine("Observación: Reprobado.");
                    break;
                default:
                    Console.WriteLine("Observación: Calificación inválida.");
                    break;
            }
        }
    }
}