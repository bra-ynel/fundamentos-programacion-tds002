using System;

class Program
{
    static void Main(string[] args)
    {
        const int ANIO_ACTUAL = 2026;

        Console.Write("Ingresa tu nombre: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Ingresa tu edad: ");
        int edad = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Ingresa tu estatura (ej. 1.75): ");
        double estatura = double.Parse(Console.ReadLine() ?? "0");

        int anioNacimiento = ANIO_ACTUAL - edad;

        Console.WriteLine("\n--- DATOS REGISTRADOS ---");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Estatura: {estatura} m");
        Console.WriteLine($"Año estimado de nacimiento: {anioNacimiento}");
    }
}