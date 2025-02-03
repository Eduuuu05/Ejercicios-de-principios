using System;

namespace PracticaDeKISS
{
    public static class Ayudantes
    {
        public static decimal ObtenerPropina()
        {
            Console.Write("Ingrese el porcentaje de propina: ");
            string? entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("Propina no válida, se usará 10%.");
                return 10;
            }

            return decimal.TryParse(entrada, out decimal propina) ? propina : 10;
        }
    }
}
