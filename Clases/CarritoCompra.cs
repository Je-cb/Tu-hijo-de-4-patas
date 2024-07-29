using System;
using System.Collections.Generic;
using System.Text;

namespace TuHijoDe4Patas
{
    internal class CarritoCompra
    {
        //Atributos

        private Producto[] productos;       //Arreglo que guarda los productos dentro del carrito
        private Producto[] AggProductos;    //Arreglo para redimensionar el carrito al agregar nuevos productos 
        private Producto[] RestProductos;   //Arreglo para redimensionar el carrito al eliminar productos
        private int contador;               //Contador de items dentro del carrito

        public CarritoCompra()
        {
            productos = new Producto[1];
            contador = 0;
        }

        //Se hace uso de un uevo vector 'AggProdcutos' con una posicion adicional para almacenar el nuevo producto y luego se redimensiona el vector 'productos' original
        //que contiene el nuevo producto 
        public void AgregarProducto(Producto item)
        {
            if (contador >= productos.Length)
            {
                AggProductos = new Producto[contador + 1];

                for (int i = 0; i < productos.Length; i++)
                {
                    AggProductos[i] = productos[i];
                }

                productos = AggProductos;
            }
            productos[contador] = item;
            contador++;
        }

        //Se hace uso de un nuevo vector 'RestProductos' con una posicion menos que el original. Luego se hace nula la posicion del vector original 'productos' y se ordena de
        //manera que esta quede posicionada al final del vector y luego se extraen los valores al vector RestProductos quedando fuera la posicion nula al final
        public void EliminarProducto(int codigo)
        {
            int indice = -1;
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i].GetCodigo() == codigo)
                {
                    indice = i;
                    break;
                }
            }

            // Eliminar producto del array y redimensionarlo 
            if (indice != -1)
            {
                productos[indice] = null;

                RestProductos = new Producto[productos.Length - 1];

                for (int i = indice; i < productos.Length - 1; i++)
                {
                    productos[i] = productos[i + 1];
                }
                for (int i = 0; i < RestProductos.Length; i++)
                {
                    RestProductos[i] = productos[i];
                }
                productos = RestProductos;
                contador--;
                Console.WriteLine(Environment.NewLine + "Producto eliminado del carrito" + Environment.NewLine);
            }
            else
            {
                Console.WriteLine("Producto no encontrado en el carrito.");
            }
        }

        public void ListarCarrito()
        {
            for (int i = 0; i < contador; i++)
            {
                productos[i].InfoProducto();
            }
        }

        public void CalcularTotal()
        {
           double total = 0;

           for (int i = 0; i < contador; i++)
            {
                total += productos[i].GetPrecio();
            }

           Console.WriteLine(total.ToString());
        }
    }
    
}
