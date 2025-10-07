using System;

namespace mis_ejercicios
{
    public class Ejercicio18 
    {
        public static void Ejecutar()
        {
            Console.WriteLine("=== Evaluación de Temperatura ===");
            Console.Write("Ingrese la temperatura en grados Celsius: ");
            if (!double.TryParse(Console.ReadLine(), out double temperatura)) {
                Console.WriteLine("Entrada inválida.");
                return;
            }

            string mensaje;
            if (temperatura < 0) {
                mensaje = "Hace mucho frío";
            } else if (temperatura <= 20) {
                mensaje = "Clima fresco";
            } else if (temperatura <= 30) {
                mensaje = "Clima agradable";
            } else {
                mensaje = "Hace mucho calor";
            }

            Console.WriteLine(mensaje);
        }
    }
}