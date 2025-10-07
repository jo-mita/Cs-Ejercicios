using System;

namespace mis_ejercicios
{
    public class Ejercicio17 
    {
        public static void Ejecutar() 
        {
            Console.WriteLine("=== Tipo de Triángulo ===");
            double[] lados = new double[3];

            for (int i = 0; i < 3; i++) {
                Console.Write($"Ingrese la longitud del lado {i + 1}: ");
                if (!double.TryParse(Console.ReadLine(), out lados[i]) || lados[i] <= 0) {
                    Console.WriteLine("Entrada inválida.");
                    return;
                }
            }

            string tipo;
            if (lados[0] == lados[1] && lados[1] == lados[2]) {
                tipo = "Equilátero";
            } else if (lados[0] == lados[1] || lados[0] == lados[2] || lados[1] == lados[2]) {
                tipo = "Isósceles";
            } else {
                tipo = "Escaleno";
            }

            Console.WriteLine($"El triángulo es: {tipo}");
        }
    }
}