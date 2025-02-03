using System;
//Eduardo Junior Rodríguez Aquino 2024-0028
class ServicioProducto
{
    public void AgregarProducto(string nombre, decimal precio)
    {
        Console.WriteLine($"Producto '{nombre}' agregado con precio {precio}.");
    }

    public void EliminarProducto(int idProducto)
    {
        Console.WriteLine($"Producto con ID {idProducto} eliminado.");
    }
}

class Program
{
    static void Main()
    {
        ServicioProducto servicio = new ServicioProducto();

        Console.WriteLine("Qué haras?:");
        Console.WriteLine("1) Agregar un producto");
        Console.WriteLine("2) Eliminar un producto");
        
        int opcion = Convert.ToInt32(Console.ReadLine());

        if (opcion == 1)
        {
            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el precio del producto: ");
            decimal precio = Convert.ToDecimal(Console.ReadLine());

            servicio.AgregarProducto(nombre, precio);
        }
        else if (opcion == 2)
        {
            Console.Write("Ingrese el ID del producto que quiere eliminar: ");
            int idProducto = Convert.ToInt32(Console.ReadLine());

            servicio.EliminarProducto(idProducto);
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }
    }
}
