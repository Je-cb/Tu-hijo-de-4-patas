using System;

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

            while (factura == false)
            {
                Console.Clear();
                string facturacion1 = $"****************************************** FACTURA {codigoFactura} ******************************************" + Environment.NewLine + Environment.NewLine +
                                      $" CLIENTE:                         {cliente.InfoPersona()}" + Environment.NewLine +
                                      $" VENDEDOR:                        {vendedor.InfoPersona()}" + Environment.NewLine +
                                      $" CODIGO DE FACTURA:               {codigoFactura}" + Environment.NewLine + Environment.NewLine +
                                      $" ITEMS:   (Cantidad de artÍculos: {orden.NumeroDeItems()})" + Environment.NewLine + Environment.NewLine;
                Console.WriteLine(facturacion1);
                orden.ListarCarrito();
                string facturacion2 = Environment.NewLine +
                                      $"SUBTOTAL:                        {orden.CalcularSubtotal()}" + Environment.NewLine +
                                      $"IVA:                             {orden.CalcularIva()}" + Environment.NewLine +
                                      $"TOTAL:                           {orden.CalcularTotal()}" + Environment.NewLine + Environment.NewLine +
                                      $" PRESIONE ENTER PARA CONTINUAR --> " + Environment.NewLine;
                Console.WriteLine(facturacion2);

                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("********************************PEDIDO FINALIZADO, GRACIAS POR SU COMPRA********************************");
                factura = true;
                codigoFactura++;
                Console.Read();
            }
        }
    }

}
