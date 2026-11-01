using System;

namespace ConversorMoneda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tasa de cambio fija (ejemplo: 1 Dólar = 60 Pesos Dominicanos)
            const double TASA_CAMBIO = 60.0;

            Console.Write("Ingrese la cantidad en Dólares (USD): ");
            double dolares = Convert.ToDouble(Console.ReadLine());

            double pesos = dolares * TASA_CAMBIO;

            Console.WriteLine("\n--- CONVERSOR DE MONEDA ---");
            Console.WriteLine($"Cantidad en USD: ${dolares}");
            Console.WriteLine($"Tasa de cambio aplicada: {TASA_CAMBIO}");
            Console.WriteLine($"Equivalente en DOP: RD$ {pesos}");
        }
    }
}