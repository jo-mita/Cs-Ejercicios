using System;

namespace mis_ejercicios
{
    public class Ejercicio15 
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ejercicio 15 - Verificación de triángulos");
            double[] sides = new double[3];
            for (int i = 0; i < 3; i++) {
                Console.Write($"Introduce la longitud del lado {i + 1}: ");
                if (!double.TryParse(Console.ReadLine(), out sides[i])) {
                    Console.WriteLine("Error: la entrada no es válida.");
                    return;
                }
            }

            string triangleStatus = sides[0] <= 0 || sides[1] <= 0 || sides[2] <= 0 ? "Lados inválidos" : 
                                    (sides[0] + sides[1] > sides[2] && sides[0] + sides[2] > sides[1] && sides[1] + sides[2] > sides[0]) ? "Pueden formar un triángulo" : 
                                    "No pueden formar un triángulo";

            Console.WriteLine(triangleStatus);

            switch (triangleStatus) {
                case "Pueden formar un triángulo":
                    Console.WriteLine("Observación: Puedes verificar el tipo de triángulo.");
                    break;
                case "No pueden formar un triángulo":
                    Console.WriteLine("Observación: Longitudes insuficientes.");
                    break;
                default:
                    Console.WriteLine("Observación: Lados inválidos.");
                    break;
            }
        }
    }
}