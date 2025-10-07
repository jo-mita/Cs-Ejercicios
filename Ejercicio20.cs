using System;

namespace mis_ejercicios
{
     public class Ejercicio20
    {
        public static void Ejecutar()
        {
            Console.WriteLine("=== Clasificación de IMC ===");
            Console.Write("Ingrese su peso (kg): ");
            if (!double.TryParse(Console.ReadLine(), out double peso)) {
                Console.WriteLine("Entrada inválida.");
                return;
            }
            Console.Write("Ingrese su altura (m): ");
            if (!double.TryParse(Console.ReadLine(), out double altura) || altura <= 0) {
                Console.WriteLine("Entrada inválida.");
                return;
            }

            double imc = peso / (altura * altura);
            string clasificacion;

            if (imc < 18.5) {
                clasificacion = "Bajo peso";
            } else if (imc < 25) {
                clasificacion = "Normal";
            } else if (imc < 30) {
                clasificacion = "Sobrepeso";
            } else {
                clasificacion = "Obesidad";
            }

            Console.WriteLine($"IMC: {imc:F2} - Clasificación: {clasificacion}");
        }
    }
}