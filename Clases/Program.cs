using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inserte los datos del Cliente" + Environment.NewLine + "Nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Apellido:");
            string apellido = Console.ReadLine();

            Console.WriteLine("Numero de identificación");
            int id = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Email:");
            string email = Console.ReadLine();

            Console.WriteLine("Teléfono:");
            string telefono = Console.ReadLine();

            Console.WriteLine("Dirección:");
            string direccion = Console.ReadLine();

            Cliente cliente1 = new Cliente(nombre, apellido, id, email, telefono, direccion);
            cliente1.InfoPersona();

            Console.ReadLine();



            /*Console.WriteLine("Mostrar datos del usuario? (1 - SI / 2 - NO)" + Environment.NewLine);
            int choice = Console.Read();

            if (choice == 1)
            {
                
            }*/
        }
    }
}
