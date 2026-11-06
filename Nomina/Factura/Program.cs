using System;

class Program
{
    static void Main()
    {
        // Constante del ITBIS
        const double TASA_ITBIS = 0.18;

        // Entrada de datos
        Console.Write("Ingrese el nombre del producto: ");
        string producto = Console.ReadLine();

        Console.Write("Ingrese la cantidad: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el precio unitario: ");
        double precioUnitario = Convert.ToDouble(Console.ReadLine());

        // Proceso: Subtotal, ITBIS y Total
        double subtotal = cantidad * precioUnitario;
        double itbis = subtotal * TASA_ITBIS;
        double total = subtotal + itbis;

        // Salida: Factura con columnas alineadas
        Console.WriteLine("\n==================================");
        Console.WriteLine("             FACTURA              ");
        Console.WriteLine("==================================");
        Console.WriteLine("Producto:".PadRight(15) + producto.PadLeft(15));
        Console.WriteLine("Cantidad:".PadRight(15) + cantidad.ToString().PadLeft(15));
        Console.WriteLine("Precio Unit.:".PadRight(15) + precioUnitario.ToString("N2").PadLeft(15));
        Console.WriteLine(new string('-', 34));
        Console.WriteLine("Subtotal:".PadRight(15) + subtotal.ToString("N2").PadLeft(15));
        Console.WriteLine("ITBIS (18%):".PadRight(15) + itbis.ToString("N2").PadLeft(15));
        Console.WriteLine("Total a Pagar:".PadRight(15) + total.ToString("N2").PadLeft(15));
        Console.WriteLine("==================================");
    }
}
