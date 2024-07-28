using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TuHijoDe4Patas
{
    internal class CarritoCompra
    {
        //Atributos
        private Producto[] productos;   //Arreglo que almacena los items en el carrito
        private int cantidadItems;      //Contador de items totales dentro del carrito

        //Constructor por defecto
        public CarritoCompra()
        {
            productos = new Producto[0]; //Tamaño inicial del array
            cantidadItems = 0;
        }

        // Agregar items al carrito
        public void AgregarProducto(Producto item)      //**verificar logica de agregacion de items al carrito
        {
            if (cantidadItems >= productos.Length)
            {
                Array.Resize(ref productos, productos.Length + 1); // Duplicar el tamaño del array
            }
            productos[cantidadItems] = item;
            cantidadItems++;
        }

        // Eliminar items del carrito
        public void  EliminarItem(int codigo)
        {
            int indice = -1;
            for (int i = 0; i < cantidadItems; i++)
            {
                if (productos[i].GetCodigo() == codigo)
                {
                    indice = i;
                    break;
                }
            }

            if (indice != -1)
            {
                for (int i = indice; i < cantidadItems - 1; i++)
                {
                    productos[i] = productos[i + 1];
                }
                productos[cantidadItems - 1] = null;
                cantidadItems--;

                // Redimensionar el array si es necesario
                //if (cantidadProductos > 0 && cantidadProductos <= productos.Length / 4)
                //{
                //    Array.Resize(ref productos, productos.Length / 2);
                //}
            }
            else
            {
                Console.WriteLine("Producto no encontrado en el carrito.");
            }
        }

        public void ListarProductos()
        {
            for(int i = 0;i < cantidadItems;i++)
            {
                Console.WriteLine($"productos[i].InfoProducto()");
            }
        }

        public void CalcularTotal()
        {
            double total = 0;

            for (int i = 0; i < cantidadItems; i++)
            {
                total += productos[i].GetPrecio();
            }

            Console.WriteLine(total);
        }
    }
}
