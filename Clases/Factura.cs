using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;

namespace TuHijoDe4Patas
{
    internal class Factura
    {
        private int codigoFactura;
        private Cliente cliente;
        private Vendedor vendedor;
        private CarritoCompra orden;

        public Factura(Cliente cliente, Vendedor vendedor, CarritoCompra orden)
        {
            codigoFactura = 1;
            this.cliente = cliente;
            this.vendedor = vendedor;
            this.orden = orden;
        }

        public void FinalizarFactura()
        {
            var factura = false;
            int seleccion;

            while (factura == false)
            {
                Console.Clear();
                string facturacion1 = $"******************************************CONFIRME SU PEDIDO******************************************" + Environment.NewLine + Environment.NewLine +
                                      $"CLIENTE:                         {cliente}" + Environment.NewLine +
                                      $"VENDEDOR:                        {vendedor}" + Environment.NewLine +
                                      $"CODIGO DE FACTURA:               {codigoFactura}" + Environment.NewLine + Environment.NewLine +
                                      $"ITEMS:   (Cantidad de articulos: {orden.NumeroDeItems()})" + Environment.NewLine + Environment.NewLine;
                Console.WriteLine(facturacion1);
                orden.ListarCarrito();
                string facturacion2 = Environment.NewLine +
                                      $"SUBTOTAL:                        {orden.CalcularSubtotal()}" + Environment.NewLine +
                                      $"IVA:                             {orden.CalcularIva()}" + Environment.NewLine +
                                      $"TOTAL:                           {orden.CalcularTotal()}" + Environment.NewLine + Environment.NewLine +
                                      $"SELECCIONE UNA OPCION: 1 - CONFIRMAR | 2 - REGRESAR" + Environment.NewLine;
                Console.WriteLine(facturacion2);

                seleccion = Console.Read();

                switch (seleccion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("********************************PEDIDO FINALIZADO, GRACIAS POR SU COMPRA********************************");
                        factura = true;
                        codigoFactura++;
                        Console.Read();
                        break;

                    case 2:
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("*******************************************OPCION NO VALIDA*******************************************");
                        Console.Read();
                        break;
                }
            }
        }

    }
}
