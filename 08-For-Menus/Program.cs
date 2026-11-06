using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion = -1;
        do
        {
            Console.Clear();
            Console.WriteLine("=========================================");
            Console.WriteLine("   ACTIVIDAD EN CLASE - SEMANA 8 (ITLA)");
            Console.WriteLine("=========================================");
            Console.WriteLine("1. Tablas de multiplicar (1 al 10)");
            Console.WriteLine("2. Triángulo de asteriscos");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        MostrarTablas();
                        break;
                    case 2:
                        MostrarTriangulo();
                        break;
                    case 0:
                        Console.WriteLine("\n¡Saliendo del programa! Éxito con tu entrega.");
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

            if (opcion != 0)
            {
                Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                Console.ReadKey();
            }

        } while (opcion != 0);
    }

    // 1. Tablas de multiplicar del 1 al 10 con ciclos anidados y formato {valor,4}
    static void MostrarTablas()
    {
        Console.Clear();
        Console.WriteLine("--- TABLAS DE MULTIPLICAR (1 al 10) ---\n");
        
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                // Multiplica i por j y lo alinea usando {valor,4}
                Console.Write($"{i * j,4}");
            }
            Console.WriteLine();
        }
    }

    // 2. Triángulo de asteriscos de N filas
    static void MostrarTriangulo()
    {
        Console.Clear();
        Console.WriteLine("--- TRIÁNGULO DE ASTERISCOS ---");
        Console.Write("Ingrese el número de filas (N): ");

        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Error: Debe ingresar un número entero positivo.");
        }
    }
}
