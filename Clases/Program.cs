using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TuHijoDe4Patas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Construccion de vendedores  iniciales
            Vendedor vendedor1 = new Vendedor("Arianna Olivares", 30685478, 1);
            Vendedor vendedor2 = new Vendedor("Alejandro Cegarra", 30436857, 2);

            vendedor1.InfoPersona();
            vendedor2.InfoPersona();

            // Cliente 
            Console.WriteLine("Inserte los datos del Cliente" + Environment.NewLine + 
                              "Introduzca cada dato en el orden indicado y presione enter" + Environment.NewLine +
                              "Nombre y apellido: " + Environment.NewLine +
                              "Numero de cedula:" + Environment.NewLine +
                              "Email:" + Environment.NewLine + 
                              "Teléfono:" + Environment.NewLine +
                              "Dirección:" + Environment.NewLine);
            
            string nombre = Console.ReadLine();
            int id = Convert.ToInt32(Console.ReadLine());
            string email = Console.ReadLine();
            string telefono = Console.ReadLine();
            string direccion = Console.ReadLine();

            Cliente cliente1 = new Cliente(nombre, id, email, telefono, direccion);
          
            cliente1.InfoPersona();

            Producto gatarina = new Producto(001, "Gatsy", "Gatarina Gatsy 8kg", 12.00, "Alimento de gato");
            
            CarritoCompra orden = new CarritoCompra();

            //orden.AgregarProducto(gatarina);

            //Console.WriteLine(Environment.NewLine + "Desea agregar gatarina al carrito?" + Environment.NewLine);

            //int decision = Console.Read();

            //if (decision == 1)
            //{
            //    orden.AgregarProducto(gatarina);
            //}

           Console.WriteLine(Environment.NewLine);

           //Console.WriteLine(gatarina.InfoProducto());

           //orden.ListarProductos();
            


            Console.ReadKey();


            /*Console.WriteLine("Mostrar datos del usuario? (1 - SI / 2 - NO)" + Environment.NewLine);
            int choice = Console.Read();

            if (choice == 1)
            {
                
            }*/
        }
    }
}
