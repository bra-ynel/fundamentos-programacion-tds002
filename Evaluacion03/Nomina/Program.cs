using System;

class Program
{
    static void Main()
    {
        // Entrada
        Console.Write("Ingrese el nombre del empleado: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese las horas trabajadas: ");
        double horasTrabajadas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el pago por hora: ");
        double pagoPorHora = Convert.ToDouble(Console.ReadLine());

        // Proceso
        double salarioBruto = horasTrabajadas * pagoPorHora;
        double afp = salarioBruto * 0.0287; // 2.87%
        double sfs = salarioBruto * 0.0304; // 3.04%
        double salarioNeto = salarioBruto - (afp + sfs);

        // Salida
        Console.WriteLine("\n--- NOMINA DE EMPLEADO ---");
        Console.WriteLine($"Nombre: {nombre.ToUpper()}");
        Console.WriteLine($"Salario Bruto: {salarioBruto:N2}");
        Console.WriteLine($"AFP (2.87%): {afp:N2}");
        Console.WriteLine($"SFS (3.04%): {sfs:N2}");
        Console.WriteLine($"Salario Neto: {salarioNeto:N2}");
    }
}