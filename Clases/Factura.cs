using System;

namespace TuHijoDe4Patas
{
    internal class Factura
    {
        private int codigoFactura;
        private int metodoPago;
        private Cliente cliente;
        private Vendedor vendedor;
        private CarritoCompra orden;

        public Factura(int metodoPago, Cliente cliente, Vendedor vendedor, CarritoCompra orden)
        {
            codigoFactura = 1;
            if(metodoPago == 1 | metodoPago == 2) // (1 - BOLIVARES / 2 - DIVISAS)
            {
                this.metodoPago = metodoPago;
            }
            else
            {
                this.metodoPago = 1;
            }
            this.cliente = cliente;
            this.vendedor = vendedor;
            this.orden = orden;
        }

        public void FinalizarFactura()
        {
            var factura = false;

            while (factura == false)
            {

                if (metodoPago == 2)    //CALCULO DE IGTF CUANDO EL METODO DE PAGO SON DIVISAS
                {
                    if(cliente.TipoContribuyente())     //IGTF DEL 2% APLICA CUANDO EL CLIENTE ES CONTRIBUYENTE ESPECIAL
                    {
                        Console.Clear();
                        string facturacion1 = $"****************************************** FACTURA {codigoFactura} ******************************************" + Environment.NewLine + Environment.NewLine +
                                              $" CLIENTE:                         {cliente.InfoPersona()}" + Environment.NewLine +
                                              $" VENDEDOR:                        {vendedor.InfoPersona()}" + Environment.NewLine +
                                              $" CÓDIGO DE FACTURA:               {codigoFactura}" + Environment.NewLine + Environment.NewLine +
                                              $" ITEMS:   (Cantidad de artÍculos: {orden.NumeroDeItems()})" + Environment.NewLine + Environment.NewLine;
                        Console.WriteLine(facturacion1);
                        orden.ListarCarrito();
                        string facturacion2 = Environment.NewLine +
                                              $"SUBTOTAL:                        {orden.CalcularSubtotal()}" + Environment.NewLine +
                                              $"IVA:                             {orden.CalcularIva()}" + Environment.NewLine +
                                              $"IGTF:                            {orden.CalcularIGTFespecial()}" + Environment.NewLine +
                                              $"TOTAL:                           {orden.CalcularTotal() + orden.CalcularIGTFespecial()}" + Environment.NewLine + Environment.NewLine +
                                              $" PRESIONE ENTER PARA CONTINUAR --> " + Environment.NewLine;
                        Console.WriteLine(facturacion2);
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("********************************PEDIDO FINALIZADO, GRACIAS POR SU COMPRA********************************");
                        factura = true;
                        codigoFactura++;
                        Console.Read();
                    }
                    else                                //IGTF DEL 3% APLICA CUANDO EL CLIENTE NO ES CONTRIBUYENTE ESPECIAL
                    {
                        Console.Clear();
                        string facturacion1 = $"****************************************** FACTURA {codigoFactura} ******************************************" + Environment.NewLine + Environment.NewLine +
                                              $" CLIENTE:                         {cliente.InfoPersona()}" + Environment.NewLine +
                                              $" VENDEDOR:                        {vendedor.InfoPersona()}" + Environment.NewLine +
                                              $" CÓDIGO DE FACTURA:               {codigoFactura}" + Environment.NewLine + Environment.NewLine +
                                              $" ITEMS:   (Cantidad de artÍculos: {orden.NumeroDeItems()})" + Environment.NewLine + Environment.NewLine;
                        Console.WriteLine(facturacion1);
                        orden.ListarCarrito();
                        string facturacion2 = Environment.NewLine +
                                              $"SUBTOTAL:                        {orden.CalcularSubtotal()}" + Environment.NewLine +
                                              $"IVA:                             {orden.CalcularIva()}" + Environment.NewLine +
                                              $"IGTF:                            {orden.CalcularIGTF()}" + Environment.NewLine +
                                              $"TOTAL:                           {orden.CalcularTotal() + orden.CalcularIGTF()}" + Environment.NewLine + Environment.NewLine +
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
                else                    //CALCULO DE IGTF NO APLICA PARA PAGOS EN BOLIVARES
                {
                    Console.Clear();
                    string facturacion1 = $"****************************************** FACTURA {codigoFactura} ******************************************" + Environment.NewLine + Environment.NewLine +
                                          $" CLIENTE:                         {cliente.InfoPersona()}" + Environment.NewLine +
                                          $" VENDEDOR:                        {vendedor.InfoPersona()}" + Environment.NewLine +
                                          $" CÓDIGO DE FACTURA:               {codigoFactura}" + Environment.NewLine + Environment.NewLine +
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

}
