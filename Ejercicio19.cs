using System;

namespace mis_ejercicios
{
    public class Ejercicio19 
    {
        public static void Ejecutar()
        {
            Console.WriteLine("=== Conversión de Horas a Turnos ===");
            Console.Write("Ingrese la hora (0-23): ");
            if (!int.TryParse(Console.ReadLine(), out int hora) || hora < 0 || hora > 23) {
                Console.WriteLine("Entrada inválida.");
                return;
            }

            string turno;
            if (hora >= 6 && hora <= 11) {
                turno = "Mañana";
            } else if (hora >= 12 && hora <= 17) {
                turno = "Tarde";
            } else if (hora >= 18 && hora <= 23) {
                turno = "Noche";
            } else {
                turno = "Madrugada";
            }

            Console.WriteLine($"Es: {turno}");
        }
    }
}