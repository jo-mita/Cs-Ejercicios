using System;

namespace mis_ejercicios
{
    public class Ejercicio12 
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ejercicio 12 - Clasificación de números");
            double[] numbers = new double[3];
            for (int i = 0; i < 3; i++) {
                Console.Write($"Introduce el número {i + 1}: ");
                if (!double.TryParse(Console.ReadLine(), out numbers[i])) {
                    Console.WriteLine("Error: la entrada no es válida.");
                    return;
                }
            }

            bool hasZero = numbers[0] == 0 || numbers[1] == 0 || numbers[2] == 0;
            bool allPositive = numbers[0] > 0 && numbers[1] > 0 && numbers[2] > 0;
            bool allNegative = numbers[0] < 0 && numbers[1] < 0 && numbers[2] < 0;

            string classification = hasZero ? "Hay ceros" : allPositive ? "Todos son positivos" : allNegative ? "Todos son negativos" : "Mixtos";
            Console.WriteLine(classification);

            switch (classification) {
                case "Hay ceros":
                    Console.WriteLine("Observación: Revisa los ceros.");
                    break;
                case "Todos son positivos":
                    Console.WriteLine("Observación: Todos son mayores que 0.");
                    break;
                case "Todos son negativos":
                    Console.WriteLine("Observación: Todos son menores que 0.");
                    break;
                case "Mixtos":
                    Console.WriteLine("Observación: Hay mezcla de signos.");
                    break;
            }
        }
    }
}