using System;

class Program
{
    static void Main()
    {
        // Declaración de constante para la conversión de libras a kilogramos
        const double LibrasAKg = 0.453592;

        Console.WriteLine("=== CONVERSOR DE UNIDADES (SEMANA 4) ===");

        // 1. Entrada de datos
        Console.Write("Ingresa el peso en libras (lb): ");
        double libras = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la temperatura en grados Fahrenheit (°F): ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // 2. Proceso (Conversiones)
        double kilogramos = libras * LibrasAKg;
        double celsius = (fahrenheit - 32) * 5.0 / 9.0;

        // 3. Salida de resultados con formato de 2 decimales ({valor:F2})
        Console.WriteLine("\n--- RESULTADOS DE LA CONVERSIÓN ---");
        Console.WriteLine($"Peso ingresado: {libras:F2} lb");
        Console.WriteLine($"Equivalente en kilogramos: {kilogramos:F2} kg");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"Temperatura ingresada: {fahrenheit:F2} °F");
        Console.WriteLine($"Equivalente en Celsius: {celsius:F2} °C");
    }
}
