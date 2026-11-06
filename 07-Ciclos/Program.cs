using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=========================================");
        Console.WriteLine("   ACTIVIDAD EN CLASE - SEMANA 7 (ITLA)");
        Console.WriteLine("=========================================");

        int numero = 0;
        bool esValido = false;

        // 1. Pide un número entre 1 y 12 y valídalo con do-while
        do
        {
            Console.Write("Ingrese un número entre 1 y 12: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numero))
            {
                if (numero >= 1 && numero <= 12)
                {
                    esValido = true;
                }
                else
                {
                    Console.WriteLine("Error: El número debe estar estrictamente entre 1 y 12.");
                }
            }
            else
            {
                Console.WriteLine("Error: Debe ingresar un número entero válido.");
            }

        } while (!esValido);

        Console.WriteLine($"\n--- Tabla de multiplicar del {numero} ---");

        int contador = 1;
        int sumaTotal = 0;

        // 2. Muestra su tabla de multiplicar del 1 al 12 con while (usa un contador)
        while (contador <= 12)
        {
            int resultado = numero * contador;
            Console.WriteLine($"{numero} x {contador} = {resultado}");

            // 3. Acumulador para sumar todos los resultados
            sumaTotal += resultado;

            contador++;
        }

        // Muestra la suma de todos los resultados al final
        Console.WriteLine($"\nLa suma de todos los resultados es: {sumaTotal}");
        
        Console.WriteLine("\nPresione cualquier tecla para finalizar...");
        Console.ReadKey();
    }
}