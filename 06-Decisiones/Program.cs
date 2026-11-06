using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("=========================================");
            Console.WriteLine("   ACTIVIDAD EN CLASE - SEMANA 6 (ITLA)");
            Console.WriteLine("=========================================");
            Console.WriteLine("1. Parte 1: Calificación (0-100 a Letra)");
            Console.WriteLine("2. Parte 2: Calculadora Básica (+, -, *, /)");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción (1-3): ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        EjecutarCalificacion();
                        break;
                    case 2:
                        EjecutarCalculadora();
                        break;
                    case 3:
                        Console.WriteLine("\n¡Saliendo del programa. ¡Éxito con tu entrega!");
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nEntrada inválida.");
            }

            if (opcion != 3)
            {
                Console.WriteLine("\nPresione una tecla para volver al menú...");
                Console.ReadKey();
            }

        } while (opcion != 3);
    }

    // PARTE 1: Calificación con if-else if-else e int.TryParse
    static void EjecutarCalificacion()
    {
        Console.Clear();
        Console.WriteLine("--- PARTE 1: CALIFICACIÓN ---");
        Console.Write("Ingrese una nota (0-100): ");

        // Validación con int.TryParse como pide la consigna
        if (int.TryParse(Console.ReadLine(), out int nota))
        {
            if (nota >= 0 && nota <= 100)
            {
                if (nota >= 90)
                {
                    Console.WriteLine($"Calificación: A (Nota: {nota})");
                }
                else if (nota >= 80)
                {
                    Console.WriteLine($"Calificación: B (Nota: {nota})");
                }
                else if (nota >= 70)
                {
                    Console.WriteLine($"Calificación: C (Nota: {nota})");
                }
                else
                {
                    Console.WriteLine($"Calificación: F (Nota: {nota})");
                }
            }
            else
            {
                Console.WriteLine("Error: La nota debe estar en el rango de 0 a 100[cite: 2].");
            }
        }
        else
        {
            Console.WriteLine("Error: Debe ingresar un número entero válido.");
        }
    }

    // PARTE 2: Calculadora con switch y control de división entre 0
    static void EjecutarCalculadora()
    {
        Console.Clear();
        Console.WriteLine("--- PARTE 2: CALCULADORA ---");
        
        Console.Write("Ingrese el primer número: ");
        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Número inválido.");
            return;
        }

        Console.Write("Ingrese el segundo número: ");
        if (!double.TryParse(Console.ReadLine(), out double num2))
        {
            Console.WriteLine("Número inválido.");
            return;
        }

        Console.WriteLine("\nSeleccione la opción:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.Write("Opción (1-4): ");

        if (int.TryParse(Console.ReadLine(), out int operacion))
        {
            switch (operacion)
            {
                case 1:
                    Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado: {num1} * {num2} = {num1 * num2}");
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: No se puede dividir entre 0[cite: 2].");
                    }
                    else
                    {
                        Console.WriteLine($"Resultado: {num1} / {num2} = {num1 / num2}");
                    }
                    break;
                default:
                    Console.WriteLine("Opción de operación no válida[cite: 2].");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Opción inválida.");
        }
    }
}