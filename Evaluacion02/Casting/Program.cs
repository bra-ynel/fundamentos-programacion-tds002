using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- CONVERSIÓN DE TIPOS (CASTING) ---");

            // 1. Conversión implícita (de menor a mayor capacidad)
            int numeroEntero = 42;
            double numeroDecimal = numeroEntero; // Implícita: int a double
            Console.WriteLine($"Entero original: {numeroEntero}");
            Console.WriteLine($"Convertido a double (implícito): {numeroDecimal}");

            // 2. Conversión explícita (Casting de mayor a menor capacidad)
            double pi = 3.14159;
            int piEntero = (int)pi; // Explícita: double a int (se pierde la parte decimal)
            Console.WriteLine($"\nDouble original: {pi}");
            Console.WriteLine($"Convertido a int (explícito con casting): {piEntero}");

            // 3. Conversión usando Convert
            string textoNumero = "123";
            int numeroConvertido = Convert.ToInt32(textoNumero);
            Console.WriteLine($"\nTexto original: \"{textoNumero}\"");
            Console.WriteLine($"Convertido a int usando Convert: {numeroConvertido}");
        }
    }
}