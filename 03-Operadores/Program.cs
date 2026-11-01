using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== PROGRAMA DE OPERADORES ARITMÉTICOS Y LÓGICOS ===");

        // Leer el primer número entero
        Console.Write("Ingresa el primer número entero: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        // Leer el segundo número entero
        Console.Write("Ingresa el segundo número entero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n--- RESULTADOS ---");

        // 1. Suma
        int suma = numero1 + numero2;
        Console.WriteLine($"Suma: {numero1} + {numero2} = {suma}");

        // 2. Resta
        int resta = numero1 - numero2;
        Console.WriteLine($"Resta: {numero1} - {numero2} = {resta}");

        // 3. Producto
        int producto = numero1 * numero2;
        Console.WriteLine($"Producto: {numero1} * {numero2} = {producto}");

        // 4. División real y 5. División entera (Validando división entre cero)
        if (numero2 != 0)
        {
            double divisionReal = (double)numero1 / numero2;
            int divisionEntera = numero1 / numero2;
            int residuo = numero1 % numero2;

            Console.WriteLine($"División real: {numero1} / {numero2} = {divisionReal}");
            Console.WriteLine($"División entera: {numero1} / {numero2} = {divisionEntera}");
            Console.WriteLine($"Residuo (Módulo): {numero1} % {numero2} = {residuo}");
        }
        else
        {
            Console.WriteLine("División real, entera y residuo: No se puede dividir entre cero.");
        }

        // 6. Verificar si el primer número es par (true/false)
        bool esPar = (numero1 % 2 == 0);
        Console.WriteLine($"¿El primer número ({numero1}) es par?: {esPar}");
    }
}

