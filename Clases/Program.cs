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
            //Ajustes de consola
            Console.Title = "TU HIJO DE 4 PATAS";
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Crear vendedores
            Vendedor vendedor1 = new Vendedor("Arianna", "Olivares", 445, 1);
            Vendedor vendedor2 = new Vendedor("Luis", "Ortega", 5587, 2);
            Vendedor vendedor3 = new Vendedor("Jorge", "Carrero", 29558741, 3);

            // Crear arreglo de vendedores
            Vendedor[] vendedores = { vendedor1, vendedor2, vendedor3 };

            // Menú
            Console.WriteLine("TU HIJO DE 4 PATAS"
                + Environment.NewLine + Environment.NewLine +
                "MENÚ DE VENDEDORES"
            );
                Console.WriteLine("1. Ingresar como vendedor");
                Console.WriteLine("2. Agregar vendedor");
                //Console.WriteLine("3. Salir");
                Console.Write("Opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "0":
                    Console.Clear();
                    Console.WriteLine("1. Ingresar como vendedor");
                    Console.WriteLine("2. Agregar vendedor");
                    Console.WriteLine("3. Salir");
                    Console.Write("Opción: ");
                    opcion = Console.ReadLine();
                    break;
                    case "1":
                        Console.Write("Ingrese su código del vendedor: ");
                        int codigoBuscar = Convert.ToInt32(Console.ReadLine());

                    // Buscar vendedor por código
                    Vendedor vendedorEncontrado = vendedor1.BuscarVendedor(codigoBuscar, vendedores);

                    if (vendedorEncontrado != null)
                    {
                        vendedorEncontrado.InfoPersona();
                    }
                    else
                    {
                        Console.WriteLine("Vendedor no encontrado.");
                    }
                    break;
                    case "2":
                    // Crear un nuevo vendedor
                        Console.WriteLine("Inserte los datos del nuevo vendedor" + Environment.NewLine);
                        Console.Write("Nombre: ");
                        string nombreVendedor = Console.ReadLine();

                        Console.Write("Apellido: ");
                        string apellidoVendedor = Console.ReadLine();

                        Console.Write("Número de identificación: ");
                        int idVendedor = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Código de Vendedor: ");
                        int codVendedor = Convert.ToInt32(Console.ReadLine());

                        Vendedor vendedor = new Vendedor(nombreVendedor, apellidoVendedor, idVendedor, codVendedor);
                        Console.WriteLine( Environment.NewLine + "Vendedor Agregado correctamente");
                        vendedor.InfoPersona();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            
        }

    }
    }



//            // Cliente 
//            Console.WriteLine("Inserte los datos del Cliente" + Environment.NewLine + "Nombre:");
//            string nombre = Console.ReadLine();

//            Console.WriteLine("Apellido:");
//            string apellido = Console.ReadLine();

//            Console.WriteLine("Numero de identificación");
//            int id = Convert.ToInt32(Console.ReadLine());
            
//            Console.WriteLine("Email:");
//            string email = Console.ReadLine();

//            Console.WriteLine("Teléfono:");
//            string telefono = Console.ReadLine();

//            Console.WriteLine("Dirección:");
//            string direccion = Console.ReadLine();

//            Cliente cliente1 = new Cliente(nombre, apellido, id, email, telefono, direccion);
//            cliente1.InfoPersona();

//            Console.ReadLine();

            

