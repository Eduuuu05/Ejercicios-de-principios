using System;
//Eduardo Junior Rodríguez Aquino 2024-0028
class CalculadoraSalarios
{
    public static decimal CalcularSalarioNeto(decimal salario)
    {
        decimal impuesto = salario * 0.18m;
        decimal bono = salario * 0.05m;
        return salario - impuesto + bono;
    }

    static void Main()
    {
        Console.WriteLine("Seleccione el tipo de empleado #1: Tiempo completo, #2: Medio tiempo): ");
        int tipoEmpleado = Convert.ToInt32(Console.ReadLine());

        decimal salarioNeto = 0;

        if (tipoEmpleado == 1)  
        {
            Console.Write("Ingrese el salario base: ");
            decimal salarioBase = Convert.ToDecimal(Console.ReadLine());
            salarioNeto = CalcularSalarioNeto(salarioBase);
        }
        else if (tipoEmpleado == 2)  
        {
            Console.Write("Ingrese el sueldo por hora: ");
            decimal tarifaPorHora = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingrese las horas trabajadas: ");
            int horasTrabajadas = Convert.ToInt32(Console.ReadLine());

            decimal salarioTotal = tarifaPorHora * horasTrabajadas;
            salarioNeto = CalcularSalarioNeto(salarioTotal);
        }
        else
        {
            Console.WriteLine("Opción no válida.");
            return;
        }

        Console.WriteLine($"Salario neto después de impuestos y bono: {salarioNeto}");
    }
}
