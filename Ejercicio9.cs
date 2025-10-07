using System;

namespace mis_ejercicios
{
    public class Ejercicio9
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ejercicio 9 - Clasificación de IMC");
            Console.Write("Introduce tu peso (kg): ");
            if (!double.TryParse(Console.ReadLine(), out double weight)) {
                Console.WriteLine("Error: la entrada no es válida.");
                return;
            }
            Console.Write("Introduce tu altura (m): ");
            if (!double.TryParse(Console.ReadLine(), out double height) || height <= 0) {
                Console.WriteLine("Error: la entrada no es válida.");
                return;
            }

            double imc = weight / (height * height);
            string classification = imc < 18.5 ? "Bajo peso" : imc < 25 ? "Normal" : imc < 30 ? "Sobrepeso" : "Obesidad";

            Console.WriteLine($"IMC: {imc:F2} - Clasificación: {classification}");

            switch (classification) {
                case "Bajo peso":
                    Console.WriteLine("Observación: Considera ganar peso.");
                    break;
                case "Normal":
                    Console.WriteLine("Observación: Mantén hábitos saludables.");
                    break;
                case "Sobrepeso":
                    Console.WriteLine("Observación: Vigila tu dieta.");
                    break;
                case "Obesidad":
                    Console.WriteLine("Observación: Consulta un profesional.");
                    break;
            }
        }
    }
}