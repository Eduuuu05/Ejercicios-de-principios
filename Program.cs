using System;
//Eduardo Junior Rodríguez Aquino 2024-0028.
namespace PracticaDeKISS
{
    class Program 
    {
        static void Main() 
        {
            Console.Write("Ingrese los precios de los platos (separados por comas): ");
            string? entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("No se ingresaron precios válidos.");
                return;
            }

            decimal[] precios = Cuenta.ConvertirPrecios(entrada);

            Console.Write("¿Desea agregar una propina personalizada? (s/n): ");
            string? respuesta = Console.ReadLine()?.Trim().ToLower();

            decimal porcentajePropina = (respuesta == "s") ? Ayudantes.ObtenerPropina() : 10;

            decimal total = Cuenta.CalcularTotal(precios, porcentajePropina);
            Console.WriteLine($"Total a pagar (con propina del {porcentajePropina}%): {total}");
        }
    }
}
