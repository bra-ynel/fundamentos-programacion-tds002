using System;

namespace FichaPersonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pide el nombre (string)
            Console.Write("Ingrese su nombre: ");
            string nombrePersona = Console.ReadLine() ?? "";

            // Pide la edad (int) y la convierte de forma segura
            Console.Write("Ingrese su edad: ");
            int edadPersona = Convert.ToInt32(Console.ReadLine());

            // Pide la estatura (double) y la convierte de forma segura
            Console.Write("Ingrese su estatura en metros (ej. 1.75): ");
            double estaturaPersona = Convert.ToDouble(Console.ReadLine());

            // Pide si trabaja (bool) y lo convierte de forma segura
            Console.Write("¿Trabaja actualmente? (true/false): ");
            bool trabajaPersona = Convert.ToBoolean(Console.ReadLine());

            // Calcula el año en que cumplirá 30 años
            int anioActual = DateTime.Now.Year;
            int anioCumpleTreinta = anioActual + (30 - edadPersona);

            // Muestra la ficha usando interpolación y formato claro
            Console.WriteLine("\n--- FICHA PERSONAL ---");
            Console.WriteLine($"Nombre: {nombrePersona}");
            Console.WriteLine($"Edad: {edadPersona} años");
            Console.WriteLine($"Estatura: {estaturaPersona} m");
            Console.WriteLine($"¿Trabaja?: {(trabajaPersona ? "Sí" : "No")}");
            Console.WriteLine($"Año en que cumplirá 30 años: {anioCumpleTreinta}");
        }
    }
}
