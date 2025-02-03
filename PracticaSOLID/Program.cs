using System;
// Eduardo Junior Rodriguez Aquino 2024-0028
class ServicioNotificacion
{
    public void EnviarEmail(string correo, string mensaje)
    {
        Console.WriteLine($"Enviando Email a {correo}: {mensaje}");
    }

    public void EnviarSMS(string numeroTelefono, string mensaje)
    {
        Console.WriteLine($"Enviando SMS a {numeroTelefono}: {mensaje}");
    }
}

class ServicioRegistro
{
    public void RegistrarNotificacion(string mensaje)
    {
        Console.WriteLine($"Notificación registrada en logs: {mensaje}");
    }
}

class Program
{
    static void Main()
    {
        ServicioNotificacion servicioNotificacion = new ServicioNotificacion();
        ServicioRegistro servicioRegistro = new ServicioRegistro();

        Console.WriteLine("Seleccione el tipo de notificación:");
        Console.WriteLine("1. Email");
        Console.WriteLine("2. SMS");

        int opcion = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el mensaje: ");
        string mensaje = Console.ReadLine();

        if (opcion == 1)
        {
            Console.Write("Ingrese el correo electrónico: ");
            string correo = Console.ReadLine();
            servicioNotificacion.EnviarEmail(correo, mensaje);
        }
        else if (opcion == 2)
        {
            Console.Write("Ingrese el número de teléfono: ");
            string numeroTelefono = Console.ReadLine();
            servicioNotificacion.EnviarSMS(numeroTelefono, mensaje);
        }
        else
        {
            Console.WriteLine("Opción no válida.");
            return;
        }

        servicioRegistro.RegistrarNotificacion(mensaje);
    }
}
