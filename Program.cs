using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion = 0;
        double tarifaDiaria = 25.00; // Tarifa base por día de préstamo

        do
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("       SISTEMA DE GESTION DE BIBLIOTECA           ");
            Console.WriteLine("==================================================");
            Console.WriteLine("1. Consultar catálogo de libros");
            Console.WriteLine("2. Calcular costo de préstamo");
            Console.WriteLine("3. Simular proceso de préstamo múltiple");
            Console.WriteLine("4. Calcular multa por retraso en devolución");
            Console.WriteLine("5. Salir");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Seleccione una opción: ");

            // Validación de entradas con TryParse (Requisito 4)
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("=== CATÁLOGO DE LIBROS DISPONIBLES ===");
                        MostrarCatalogoLibros(); // Método propio (1)
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("=== CÁLCULO DE COSTO DE PRÉSTAMO ===");
                        Console.Write("Ingrese la cantidad de días del préstamo: ");
                        if (int.TryParse(Console.ReadLine(), out int dias))
                        {
                            // Método con parámetros y return (Requisito 2)
                            double costoTotal = CalcularCostoPrestamo(dias, tarifaDiaria);
                            Console.WriteLine($"\nEl costo total por {dias} días es: RD$ {costoTotal:F2}");
                        }
                        else
                        {
                            Console.WriteLine("Días inválidos. Debe ingresar un número entero.");
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("=== SIMULACIÓN DE PRÉSTAMO MÚLTIPLE ===");
                        SimularPrestamoMultiple(); // Método propio con ciclos (Requisito 3)
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("=== CÁLCULO DE MULTA POR RETRASO ===");
                        Console.Write("Ingrese los días de retraso: ");
                        if (int.TryParse(Console.ReadLine(), out int diasAtraso))
                        {
                            // Método con parámetros y return (Requisito 2)
                            double multa = CalcularMulta(diasAtraso);
                            Console.WriteLine($"\nLa multa acumulada por {diasAtraso} días de retraso es: RD$ {multa:F2}");
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida para los días de retraso.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("\nSaliendo del sistema de biblioteca. ¡Hasta luego!");
                        break;

                    default:
                        Console.WriteLine("\nOpción no válida. Por favor, elija entre 1 y 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nEntrada inválida. Debe ingresar un número entero.");
            }

            if (opcion != 5)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 5); // Menú principal con do-while (Requisito 1)
    }

    // --- MÉTODOS PROPIOS (Requisito 2: Al menos 4 métodos, 2 con parámetros y 2 con return)[cite: 2] ---

    // Método 1: Sin parámetros, sin return (void) - Salida con formato (Requisito 5)[cite: 2]
    static void MostrarCatalogoLibros()
    {
        Console.WriteLine("{0,-5} | {1,-35} | {2,-20}", "ID", "Título del Libro", "Categoría");
        Console.WriteLine(new string('-', 68));
        Console.WriteLine("{0,-5} | {1,-35} | {2,-20}", "001", "Cien Años de Soledad", "Novela / Realismo");
        Console.WriteLine("{0,-5} | {1,-35} | {2,-20}", "002", "Clean Code: A Handbook", "Ing. de Software");
        Console.WriteLine("{0,-5} | {1,-35} | {2,-20}", "003", "El Principito", "Literatura Infantil");
        Console.WriteLine("{0,-5} | {1,-35} | {2,-20}", "004", "Base de Datos en C# y SQL", "Tecnología");
    }

    // Método 2: Con parámetros y con return (Requisito 2)[cite: 2] - Calcula el costo del préstamo con descuento
    static double CalcularCostoPrestamo(int diasPrestamo, double tarifa)
    {
        double subtotal = diasPrestamo * tarifa;
        // Uso de decisiones if (Requisito 3)[cite: 2]
        if (diasPrestamo > 7)
        {
            subtotal = subtotal * 0.90; // 10% de descuento si pasa de 7 días
        }
        return subtotal;
    }

    // Método 3: Sin parámetros, usa ciclos for (Requisito 3)[cite: 2]
    static void SimularPrestamoMultiple()
    {
        Console.WriteLine("Procesando libros seleccionados para préstamo:");
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"[Proceso] Verificando disponibilidad del libro virtual #{i}...");
        }
        Console.WriteLine("¡Préstamo múltiple registrado exitosamente!");
    }

    // Método 4: Con parámetros y con return (Requisito 2)[cite: 2] - Calcula multa con ciclo while (Requisito 3)[cite: 2]
    static double CalcularMulta(int diasAtraso)
    {
        double costoPorDiaMulta = 50.00;
        double totalMulta = 0;
        
        int contador = 1;
        while (contador <= diasAtraso)
        {
            totalMulta += costoPorDiaMulta;
            contador++;
        }
        return totalMulta;
    }
}
