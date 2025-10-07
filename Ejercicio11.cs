using System;

namespace mis_ejercicios
{
    public class Ejercicio11
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ejercicio 11 - Cálculo de impuestos");
            Console.Write("Introduce tu salario mensual: ");
            if (!double.TryParse(Console.ReadLine(), out double salary)) {
                Console.WriteLine("Error: la entrada no es válida.");
                return;
            }

            double taxRate;
            if (salary < 0) {
                Console.WriteLine("Salario inválido.");
                return;
            } else if (salary < 10000) {
                taxRate = 0.0;
            } else if (salary <= 30000) {
                taxRate = 0.10;
            } else {
                taxRate = 0.20;
            }

            double tax = salary * taxRate;
            double netSalary = salary - tax;
            Console.WriteLine($"Tasa: {taxRate * 100}% - Impuesto: {tax} - Salario neto: {netSalary}");

            int taxKey = taxRate == 0 ? 0 : Math.Abs(taxRate - 0.10) < 1e-9 ? 10 : 20;

            switch (taxKey) {
                case 0:
                    Console.WriteLine("Observación: Estás exento de impuestos.");
                    break;
                case 10:
                    Console.WriteLine("Observación: Tienes una tasa media.");
                    break;
                case 20:
                    Console.WriteLine("Observación: Tienes una tasa alta.");
                    break;
            }
        }
    }
}