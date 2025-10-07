using System;

namespace mis_ejercicios
{
    public class Ejercicio7
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ejercicio 7 - Identificación de días de la semana");
            Console.Write("Introduce un número del 1 al 7: ");
            if (!int.TryParse(Console.ReadLine(), out int day)) {
                Console.WriteLine("Error: la entrada no es válida.");
                return;
            }

            string dayName = day switch {
                1 => "Lunes",
                2 => "Martes",
                3 => "Miércoles",
                4 => "Jueves",
                5 => "Viernes",
                6 => "Sábado",
                7 => "Domingo",
                _ => "Fuera de rango"
            };

            Console.WriteLine(dayName);

            switch (day) {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Observación: Es un día laborable.");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Observación: Es fin de semana.");
                    break;
                default:
                    Console.WriteLine("Observación: Número inválido.");
                    break;
            }
        }
    }
}