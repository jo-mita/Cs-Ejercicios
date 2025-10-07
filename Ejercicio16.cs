using System;

namespace mis_ejercicios
{
    public class Ejercicio16 
    {
        public static void Ejecutar()
        {
            Console.WriteLine("=== Calculadora de Descuentos ===");
            Console.Write("Ingrese el precio del producto: ");
            if (!double.TryParse(Console.ReadLine(), out double precio)) {
                Console.WriteLine("Entrada inválida.");
                return;
            }

            double descuento;
            if (precio < 50) {
                descuento = 0;
            } else if (precio <= 100) {
                descuento = precio * 0.05;
            } else {
                descuento = precio * 0.10;
            }

            double precioFinal = precio - descuento;
            Console.WriteLine($"Descuento: {descuento:C} - Precio final: {precioFinal:C}");
        }
    }
}