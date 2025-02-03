using System;
using System.Linq;

namespace PracticaDeKISS
{
    public static class Cuenta
    {
        public static decimal[] ConvertirPrecios(string entrada)
        {
            return entrada.Split(',')
                          .Select(p => decimal.Parse(p.Trim()))
                          .ToArray();
        }

        public static decimal CalcularTotal(decimal[] precios, decimal porcentajePropina)
        {
            decimal subtotal = precios.Sum();
            return subtotal + (subtotal * porcentajePropina / 100);
        }
    }
}
