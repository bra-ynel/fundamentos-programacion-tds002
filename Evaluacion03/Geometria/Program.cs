using System;

class Program
{
    static void Main()
    {
        // Constantes y Variables (Entrada)
        const double TASA_ITBIS = 0.18;

        Console.Write("Ingrese el nombre del producto: ");
        string producto = Console.ReadLine();

        Console.Write("Ingrese la cantidad: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el precio unitario: ");
        double precioUnitario = Convert.ToDouble(Console.ReadLine());

        // Proceso
        double subtotal = cantidad * precioUnitario;
        double itbis = subtotal * TASA_ITBIS;
        double total = subtotal + itbis;

        // Salida (Columnas alineadas)
        Console.WriteLine("\n==============================");
        Console.WriteLine("           FACTURA            ");
        Console.WriteLine("==============================");
        Console.WriteLine($"{"Producto:",-15} {producto}");
        Console.WriteLine($"{"Cantidad:",-15} {cantidad}");
        Console.WriteLine($"{"Precio Unitario:",-15} {precioUnitario:N2}");
        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"{"Subtotal:",-15} {subtotal:N2}");
        Console.WriteLine($"{"ITBIS (18%):",-15} {itbis:N2}");
        Console.WriteLine($"{"Total:",-15} {total:N2}");
        Console.WriteLine("==============================");
    }
}