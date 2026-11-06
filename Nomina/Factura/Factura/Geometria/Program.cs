using System;

class Program
{
    static void Main()
    {
        // Entrada de datos - Círculo
        Console.Write("Ingrese el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        // Entrada de datos - Triángulo Rectángulo
        Console.Write("Ingrese el cateto A del triángulo rectángulo: ");
        double catetoA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el cateto B del triángulo rectángulo: ");
        double catetoB = Convert.ToDouble(Console.ReadLine());

        // Proceso: Cálculos usando Math.PI, Math.Pow y Math.Sqrt
        double areaCirculo = Math.PI * Math.Pow(radio, 2);
        double circunferencia = 2 * Math.PI * radio;
        double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));

        // Salida con formato de 2 decimales
        Console.WriteLine("\n--- RESULTADOS GEOMÉTRICOS ---");
        Console.WriteLine($"Área del círculo: {areaCirculo:N2}");
        Console.WriteLine($"Circunferencia del círculo: {circunferencia:N2}");
        Console.WriteLine($"Hipotenusa del triángulo: {hipotenusa:N2}");
    }
}