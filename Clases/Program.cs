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
            Console.Title = "TU HIJO DE 4 PATAS";
            // Crear los vendedores
            Vendedor vendedor1 = new Vendedor("Arianna", "Olivares", 445, 1);
            Vendedor vendedor2 = new Vendedor("Luis", "Ortega", 5587, 2);
            Vendedor vendedor3 = new Vendedor("Jorge", "Carrero", 29558741, 3);





            Console.WriteLine("TU HIJO DE 4 PATAS"
                + Environment.NewLine + Environment.NewLine +
                "MENÚ DE VENDEDORES"
            );
                Console.WriteLine("1. Ingresar como vendedor");
                Console.WriteLine("2. Agregar vendedor");
                Console.WriteLine("3. Salir");
                Console.Write("Opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese su código del vendedor: ");
                        int codigoBuscar = Convert.ToInt32(Console.ReadLine());

                        // Buscar vendedor por código
                        Vendedor vendedorEncontrado = BuscarVendedor(codigoBuscar, vendedor1, vendedor2, vendedor3);
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
                        // Código para agregar un nuevo vendedor
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

         //Función para buscar un vendedor por código
        static Vendedor BuscarVendedor(int codigo, Vendedor v1, Vendedor v2, Vendedor v3)
        {
            if (v1.codigo == codigo)
            {
                return v1;
            }
            else if (v2.codigo == codigo)
            {
                return v2;
            }
            else if (v3.codigo == codigo)
            {
                return v3;
            }
            else
            {
                return null;
            }
        }
    }
    }



//                Console.WriteLine("Inserte los datos del nuevo vendedor" + Environment.NewLine + "Nombre:");
//                string nombreV = Console.ReadLine();

//                Console.WriteLine("Apellido:");
//                string apellidoV = Console.ReadLine();

//                Console.WriteLine("Numero de identificación");
//                int idV = Convert.ToInt32(Console.ReadLine());

//                Console.WriteLine("Codigo de Vendedor");
//                int codV = Convert.ToInt32(Console.ReadLine());

//                Vendedor vendedor = new Vendedor(nombreV, apellidoV, idV, codV);
//            }






//            //Console.WriteLine("     1. Ver Información        2.Continuar");
//            //string opcion2 = Console.ReadLine();

//            // Vendedores 


//            if (opcion == "1")
//            {
//                Console.Clear();
//                //vendedor1.InfoPersona();
//                //vendedor2.InfoPersona();
//                //vendedor3.InfoPersona();
//            } else
//            {
//                Console.Clear();
//            }



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

            




//            /*Console.WriteLine("Mostrar datos del usuario? (1 - SI / 2 - NO)" + Environment.NewLine);
//            int choice = Console.Read();

//            if (choice == 1)
//            {
                
//            }*/
//        }
//    }
//}
