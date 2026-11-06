using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- PROGRAMA 1: CAJA REGISTRADORA ---");
        
        int cantidadProductos = 0;
        double subtotal = 0;
        double precio = 0;

        do
        {
            Console.Write("Ingrese el precio del producto (o 0 para terminar): ");
            string entrada = Console.ReadLine();

            if (double.TryParse(entrada, out precio))
            {
                if (precio > 0)
                {
                    subtotal += precio;
                    cantidadProductos++;
                }
                else if (precio < 0)
                {
                    Console.WriteLine("Error: El precio no puede ser negativo.");
                }
            }
            else
            {
                Console.WriteLine("Error: Ingrese un valor numérico válido.");
            }

        } while (precio != 0);

        double itbis = subtotal * 0.18;
        double total = subtotal + itbis;

        Console.WriteLine("\n========== TICKET DE COMPRA ==========");
        Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
        Console.WriteLine($"Subtotal: RD$ {subtotal:N2}");
        Console.WriteLine($"ITBIS (18%): RD$ {itbis:N2}");
        Console.WriteLine($"Total a pagar: RD$ {total:N2}");
        Console.WriteLine("======================================");

        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}