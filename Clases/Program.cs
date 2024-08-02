using System;
using System.Runtime.InteropServices;

namespace TuHijoDe4Patas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var caja = false;

            //Ajustes de consola
            Console.Title = "TU HIJO DE 4 PATAS";

            // Crear vendedores
            Vendedor vendedor1 = new Vendedor("Arianna", "Olivares", 445, 1);
            Vendedor vendedor2 = new Vendedor("Luis", "Ortega", 5587, 2);
            Vendedor vendedor3 = new Vendedor("Jorge", "Carrero", 29558741, 3);

            // Crear arreglo de vendedores
            Vendedor[] vendedores = { vendedor1, vendedor2, vendedor3 };

            //Crear productos para el cuidado
            Producto comidaP = new Producto(1, "Comida personalizada", "Mezcla de alimento personalizada para mascotas", 18.9, "Cuidado de mascota");
            Producto camasyM = new Producto(2, "Camas y mantas personalizadas", "Camas y mantas con diseños personalizados y grabados de nombre", 33.5, "Cuidado de mascota");
            Producto juguetes = new Producto(3, "Juguetes", "Juguetes con grabado de nombre y personalizados de acuerdo a las necesidades y tipo de mascota", 9.55, "Cuidado de mascota");
            Producto collaresyC = new Producto(4, "Collares y correas", "Collares y correas con grabado de nombre e informacion del dueño", 4.35, "Cuidado de mascota");
            Producto higiene = new Producto(5, "Accesorios de higiene", "Cepillos, cortauñas y kits de aseo personalizados", 48, "Cuidado de mascota");
            //Crear arreglo de servicios de moda
            Producto[] productos = { comidaP, camasyM, juguetes, collaresyC, higiene };

            // Crear servicios
            Servicio entrenamiento = new Servicio(6, "Entrenamiento Personalizado", "Entrenamiento personalizado en base a las necesidades de la mascota", 12.6, "Servicio");
            Servicio peluqueria = new Servicio(7, "Peluquería y estética", "Servicio de peluquería y tratamientos estéticos", 16.8, "Servicio");
            Servicio consulta = new Servicio(8, "Consulta veterinaria", "Consulta veterinaria y tratamiento para mascotas", 25.2, "Servicio");
            Servicio hospedaje = new Servicio(9, "Hospedaje", "Servicio de hospedaje para mascotas", 6.72, "Servicio");
            Servicio fotografia = new Servicio(10, "Fotografía", "Sesiones fotográficas personalizadas para mascotas", 12.6, "Servicio");
            // Crear arreglo de servicios
            Servicio[] servicios = { entrenamiento, peluqueria, consulta, hospedaje, fotografia };

            // Crear accesorios de moda
            Producto ropa = new Producto(11, "Ropa personalizada", "Ropa y disfraces exclusivos con el nombre de la mascota.", 16.5, "Accesorios de moda");
            Producto joyas = new Producto(12, "Joyas", "Collares y pulseras diseñados para las mascotas.", 20, "Accesorios de moda");
            Producto bolsos = new Producto(13, "Mochilas y transportadoras", "Personalizadas con el nombre de la mascota y diseño exclusivo.", 32.8, "Accesorios de moda");
            Producto tazas = new Producto(14, "Tazas y botellas", "Con imágenes y frases relacionadas con la mascota.", 8.45, "Accesorios de moda");
            Producto decoracion = new Producto(15, "Decoración temática", "Objetos decorativos para el hogar con motivos de mascotas.", 48, "Accesorios de moda");

            int codigoVendedor = 0;

            //Crear arreglo de accesorios de moda
            Producto[] accesorios = { ropa, joyas, bolsos, tazas, decoracion };

            while (caja == false) // Validar apertura de caja
            {
                // Menu apertura de caja
                Console.WriteLine(Environment.NewLine + "****************************************** APERTURAR CAJA ******************************************" + Environment.NewLine);
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
                        codigoVendedor = codigoBuscar;

                        // Buscar vendedor por código
                        Vendedor vendedorEncontrado = vendedor1.BuscarVendedor(codigoBuscar, vendedores);

                        if (vendedorEncontrado != null)
                        {
                            //Console.WriteLine();
                            vendedorEncontrado.InfoPersona();
                            Console.ReadKey();
                            caja = true;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Vendedor no encontrado");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        break;
                    case "2":
                        // Crear un nuevo vendedor
                        Console.WriteLine("***************************** INSERTE LOS DATOS DEL NUEVO VENDEDOR ***************************** " + Environment.NewLine);
                        Console.Write(" Nombre: ");
                        string nombreVendedor = Console.ReadLine();

                        Console.Write(" Apellido: ");
                        string apellidoVendedor = Console.ReadLine();

                        Console.Write(" Número de identificación: ");
                        int idVendedor = Convert.ToInt32(Console.ReadLine());

                        Console.Write(" Código de Vendedor: ");
                        int codVendedor = Convert.ToInt32(Console.ReadLine());


                        // Crear un nuevo vendedor
                        Vendedor nuevoVendedor = new Vendedor(nombreVendedor, apellidoVendedor, idVendedor, codVendedor);

                        // Redimensionar el arreglo de vendedores
                        Array.Resize(ref vendedores, vendedores.Length + 1);

                        // Agregar el nuevo vendedor al final
                        vendedores[vendedores.Length - 1] = nuevoVendedor;
                        Console.Clear();
                        Console.WriteLine(Environment.NewLine + "************************************ VENDEDOR AGREGADO CORRECTAMENTE *******************************************");

                        Console.WriteLine(Environment.NewLine + nuevoVendedor.InfoPersona());
                        caja = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("******************************************* OPCION NO VÁLIDA *******************************************");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        break;
                }

                Console.WriteLine();
                Console.WriteLine(" PRESIONE ENTER PARA CONTINUAR -->");
                Console.ReadKey();
                Console.Clear();
            }
            CarritoCompra carrito = new CarritoCompra();

            // Menú de caja 
            var menu = true;

            Console.WriteLine("****************************************** MENÚ DE CAJA******************************************" + Environment.NewLine);
            Console.WriteLine(" 1. INICIAR NUEVA COMPRA");
            Console.WriteLine(" 2. CONSULTAR ITEMS");
            Console.WriteLine(" 3. CERRAR CAJA");
            Console.Write(" Opción: ");
            string opcionMC = Console.ReadLine();

            switch (opcionMC)
            {
                case "1":
                    menu = false;
                    Console.Clear();
                    // Crear cliente 
                    Console.WriteLine(" ****************************************** REGISTRO DE CLIENTE ******************************************" + Environment.NewLine);

                    Console.Write(" Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write(" Apellido: ");
                    string apellido = Console.ReadLine();

                    Console.Write(" Numero de identificación: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.Write(" Email: ");
                    string email = Console.ReadLine();

                    Console.Write(" Teléfono: ");
                    string telefono = Console.ReadLine();

                    Console.Write(" Dirección: ");
                    string direccion = Console.ReadLine();

                    Cliente cliente1 = new Cliente(nombre, apellido, id, email, telefono, direccion);
                    Console.WriteLine(Environment.NewLine + cliente1.InfoPersona());

                    Console.WriteLine("PRESIONE ENTER PARA CONTINUAR -->");
                    Console.ReadKey();
                    Console.Clear();

                    //Crear mascota
                    Console.WriteLine(" ****************************************** REGISTRO DE MASCOTA ******************************************" + Environment.NewLine);

                    Console.Write(" Nombre de la mascota: ");
                    string nombreM = Console.ReadLine();

                    Console.Write(" Tipo de animal: ");
                    string tipo = Console.ReadLine();

                    Console.Write(" Raza de la mascota (-- Escribir 'NO APLICA' si es necesario): ");
                    string raza = Console.ReadLine();

                    Console.Write(" Tamaño de la mascota (-- Pequeño - Mediano - Grande): ");
                    string talla = Console.ReadLine();

                    Console.Write(" Edad de la mascota: ");
                    int edad = Convert.ToInt32(Console.ReadLine());

                    Mascota mascota1 = new Mascota(nombreM, tipo, raza, talla, edad);
                    Console.Write(mascota1.InfoMascota());

                    Console.WriteLine(Environment.NewLine + "PRESIONE ENTER PARA CONTINUAR -->");
                    Console.ReadKey();
                    Console.Clear();

                    var agg = true; // Variable para controlar la opcion de agregar items al carrito

                    while (agg)
                    {

                        Console.WriteLine("****************************************** COMPRA ****************************************** ");

                        Console.Write("INGRESE EL CÓDIGO DEL PRODUCTO: ");
                        string codItem = Console.ReadLine();

                        switch (codItem)
                        {
                            case "1":
                                carrito.AgregarItem(comidaP);
                                break;
                            case "2":
                                carrito.AgregarItem(camasyM);
                                break;
                            case "3":
                                carrito.AgregarItem(juguetes);
                                break;
                            case "4":
                                carrito.AgregarItem(collaresyC);
                                break;
                            case "5":
                                carrito.AgregarItem(higiene);
                                break;
                            case "6":
                                carrito.AgregarItem(entrenamiento);
                                break;
                            case "7":
                                carrito.AgregarItem(peluqueria);
                                break;
                            case "8":
                                carrito.AgregarItem(consulta);
                                break;
                            case "9":
                                carrito.AgregarItem(hospedaje);
                                break;
                            case "10":
                                carrito.AgregarItem(fotografia);
                                break;
                            case "11":
                                carrito.AgregarItem(ropa);
                                break;
                            case "12":
                                carrito.AgregarItem(joyas);
                                break;
                            case "13":
                                carrito.AgregarItem(bolsos);
                                break;
                            case "14":
                                carrito.AgregarItem(tazas);
                                break;
                            case "15":
                                carrito.AgregarItem(decoracion);
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(" EL CÓDIGO INGRESADO NO COINCIDE CON NINGUN PRODUCTO");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;

                        }

                        var compra = true;

                        while (compra)
                        {

                            Console.WriteLine(Environment.NewLine + Environment.NewLine + " 1. VER CARRITO"
                                + Environment.NewLine + " 2. AGREGAR NUEVO ITEM AL CARRITO"
                                 + Environment.NewLine + " 3. ELIMINAR ITEM DEL CARRITO"
                                  + Environment.NewLine + " 4. FINALIZAR COMPRA"
                                );

                            Console.Write(" Opción: ");
                            string op = Console.ReadLine();

                            switch (op)
                            {
                                case "1": // ver carrito
                                    Console.Clear();
                                    agg = false;
                                    Console.WriteLine("****************************************** CARRITO DE COMPRAS ****************************************** ");
                                    carrito.ListarCarrito();
                                    Console.WriteLine(Environment.NewLine + Environment.NewLine + " 0.VOLVER AL MENÚ  |  1. AGREGAR NUEVO ITEM AL CARRITO ");

                                    op = Console.ReadLine();
                                    switch (op)
                                    {
                                        case "0":
                                            Console.Clear();
                                            compra = true;
                                            break;
                                        case "1":
                                            compra = false;
                                            Console.Clear();
                                            agg = true;
                                            break;
                                        default:
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("*******************************************OPCION NO VÁLIDA*******************************************");
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            break;
                                    }
                                    break;
                                case "2": // agregar 
                                    Console.Clear();
                                    compra = false;
                                    agg = true;
                                    break;
                                case "3": // eliminar
                                    compra = false;
                                    Console.Clear();
                                    Console.Write(" INGRESE EL CÓDIGO DEL ITEM A ELIMINAR: ");
                                    int eliminar = Convert.ToInt32(Console.ReadLine());
                                    carrito.EliminarItem(eliminar);
                                    Console.WriteLine(Environment.NewLine + Environment.NewLine + "0.VOLVER AL MENU");
                                    op = Console.ReadLine();
                                    switch (op)
                                    {
                                        case "0":
                                            Console.Clear();
                                            compra = true;
                                            break;
                                        default:
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("*******************************************OPCION NO VÁLIDA*******************************************");
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            break;
                                    }
                                    break;
                                case "4": // facturar
                                    compra = false;
                                    agg = false;
                                    Console.Clear();

                                    if (codigoVendedor <= 3)
                                    {
                                        Vendedor vendedorEncontrado = vendedor1.BuscarVendedor(codigoVendedor, vendedores);
                                        Factura factura = new Factura(cliente1, vendedorEncontrado, carrito);
                                        factura.FinalizarFactura();
                                    }
                                    else
                                    {
                                        //Vendedor nuevoVendedor = vendedores[4];
                                        //Factura factura = new Factura(cliente1, nuevoVendedor, carrito);
                                        //factura.FinalizarFactura();
                                    }

                                    break;
                                default:
                                    compra = false;
                                    agg = false;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("*******************************************OPCION NO VÁLIDA*******************************************");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    break;
                            }
                        }
                    }

                    break;
                case "2":
                    while (menu == true)
                    {
                        Console.Clear();
                        Console.WriteLine(" 1. PRODUCTOS PARA EL CUIDADO DE MASCOTAS");
                        Console.WriteLine(" 2. SERVICIOS ESPECIALES");
                        Console.WriteLine(" 3. ACCESORIOS DE MODA");
                        Console.Write(" Opción: ");
                        string opcionI = Console.ReadLine();

                        switch (opcionI)
                        {
                            case "1":
                                Console.WriteLine("****************************************** PRODUCTOS PARA EL CUIDADO DE MASCOTAS ****************************************** ");
                                for (int i = 0; i < productos.Length; i++)
                                {
                                    Console.WriteLine(productos[i].InfoItem());
                                }
                                Console.WriteLine(Environment.NewLine + "0. VOLVER AL MENÚ");
                                string volver = Console.ReadLine();
                                if (volver == "0")
                                {
                                    Console.Clear();
                                    menu = true;
                                }
                                break;

                            case "2":
                                menu = false;
                                Console.Clear();
                                Console.WriteLine("****************************************** SERVICIOS ESPECIALES ****************************************** ");
                                for (int i = 0; i < servicios.Length; i++)
                                {
                                    Console.WriteLine(servicios[i].InfoItem());
                                }
                                Console.WriteLine(Environment.NewLine + "0. VOLVER AL MENÚ");
                                volver = Console.ReadLine();
                                if (volver == "0")
                                {
                                    Console.Clear();
                                    menu = true;
                                }
                                break;
                            case "3":
                                menu = false;
                                Console.Clear();
                                Console.WriteLine("****************************************** ACCESORIOS DE MODA ******************************************");
                                for (int i = 0; i < accesorios.Length; i++)
                                {
                                    Console.WriteLine(accesorios[i].InfoItem());
                                }
                                Console.WriteLine(Environment.NewLine + "0. VOLVER AL MENÚ");
                                volver = Console.ReadLine();
                                if (volver == "0")
                                {
                                    Console.Clear();
                                    menu = true;
                                }
                                break;
                            default:
                                menu = false;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("*******************************************OPCION NO VÁLIDA*******************************************");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                        }
                    }
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*******************************************OPCION NO VÁLIDA*******************************************");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }

            Console.ReadKey();
        }

    }
}






