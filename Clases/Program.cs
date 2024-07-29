using System;
using System.Collections.Generic;

namespace TuHijoDe4Patas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var caja = false;

            //Ajustes de consola
            Console.Title = "TU HIJO DE 4 PATAS";
            //Console.ForegroundColor = ConsoleColor.Yellow;

            // Crear vendedores
            Vendedor vendedor1 = new Vendedor("Arianna", "Olivares", 445, 1);
            Vendedor vendedor2 = new Vendedor("Luis", "Ortega", 5587, 2);
            Vendedor vendedor3 = new Vendedor("Jorge", "Carrero", 29558741, 3);

            // Crear arreglo de vendedores
            Vendedor[] vendedores = { vendedor1, vendedor2, vendedor3 };


            while (caja == false)
            {
                // Menu apertura de caja
                Console.WriteLine(Environment.NewLine + " APERTURAR CAJA" + Environment.NewLine);
                Console.WriteLine(" 1. Ingresar como vendedor");
                Console.WriteLine(" 2. Agregar vendedor");
                Console.Write(" Opción: ");

                string opcionAC = Console.ReadLine(); // opcion para aperturar caja 

                switch (opcionAC)
                {
                    case "1":
                        Console.Clear();
                        Console.Write(" Ingrese su código de vendedor: ");
                        int codigoBuscar = Convert.ToInt32(Console.ReadLine());

                        // Buscar vendedor por código
                        Vendedor vendedorEncontrado = vendedor1.BuscarVendedor(codigoBuscar, vendedores);

                        if (vendedorEncontrado != null)
                        {
                            Console.WriteLine();
                            vendedorEncontrado.InfoPersona();
                            caja = true;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Vendedor no encontrado");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        break;
                    case "2":
                        // Crear un nuevo vendedor
                        Console.WriteLine(" Inserte los datos del nuevo vendedor" + Environment.NewLine);
                        Console.Write(" Nombre: ");
                        string nombreVendedor = Console.ReadLine();

                        Console.Write(" Apellido: ");
                        string apellidoVendedor = Console.ReadLine();

                        Console.Write(" Número de identificación: ");
                        int idVendedor = Convert.ToInt32(Console.ReadLine());

                        Console.Write(" Código de Vendedor: ");
                        int codVendedor = Convert.ToInt32(Console.ReadLine());

                        Vendedor vendedor = new Vendedor(nombreVendedor, apellidoVendedor, idVendedor, codVendedor);
                        Console.WriteLine(Environment.NewLine + " Vendedor Agregado correctamente");
                        vendedor.InfoPersona();
                        caja = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Opción inválida");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        break;
                }

                Console.WriteLine();
                Console.WriteLine(" Presione enter para continuar...");
                Console.ReadKey();
                Console.Clear();
            }


                // Menú de caja 
            Console.WriteLine(" MENÚ DE CAJA" + Environment.NewLine);
            Console.WriteLine(" 1. Iniciar nueva compra");
            Console.WriteLine(" 2. Consultar Productos");
            Console.WriteLine(" 3. Cerrar caja");
            Console.Write(" Opción: ");
            string opcionMC = Console.ReadLine();

            switch (opcionMC)
            {
                case "1":
                    Console.Clear();
                    // Crear cliente 
                    Console.WriteLine(" Registro de Cliente" + Environment.NewLine + " Nombre:");
                    string nombre = Console.ReadLine();

                    Console.WriteLine(" Apellido:");
                    string apellido = Console.ReadLine();

                    Console.WriteLine(" Numero de identificación");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(" Email:");
                    string email = Console.ReadLine();

                    Console.WriteLine(" Teléfono:");
                    string telefono = Console.ReadLine();

                    Console.WriteLine(" Dirección:");
                    string direccion = Console.ReadLine();

                    Cliente cliente1 = new Cliente(nombre, apellido, id, email, telefono, direccion);
                    cliente1.InfoPersona();

                    Console.ReadKey();

                    break;
                case "2":
                    // Ver productos
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Opción inválida");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }

            Console.ReadKey();
        }

    }
}






