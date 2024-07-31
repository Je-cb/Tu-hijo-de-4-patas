using System;
using System.Collections.Generic;
using System.Text;

namespace TuHijoDe4Patas
{
    internal class CarritoCompra
    {
        //Atributos

        private Item[] Items;           //Arreglo que guarda los Items dentro del carrito
        private Item[] AggItems;        //Arreglo para redimensionar el carrito al agregar nuevos Items 
        private Item[] RestItems;       //Arreglo para redimensionar el carrito al eliminar Items
        private int contador;           //Contador de posiciones dentro del arreglo de items del carrito
        private int numeroDeItems;      //Contador de numero de articulos individuales dentro del carrito
        private double subtotal;
        private double iva;
        private double total;

        public CarritoCompra()
        {
            Items = new Item[1];
            contador = 0;
            numeroDeItems = 0;
        }

        //Se hace uso de un uevo vector 'AggItem' con una posicion adicional para almacenar el nuevo Item y luego se redimensiona el vector 'Items' original
        //que contiene el nuevo Item 
        public void AgregarItem(Item item)

        {
            for (int i = 0; i < contador; i++)
            {
                if (Items[i].GetCodigo() == item.GetCodigo())           //Comprobar si el item ya se encuentra dentro del carrito
                {
                    Items[i].SetCantidad();                             //Aumenta en 1 la propiedad de cantidad del item en caso de encontrarse
                    Console.WriteLine("El item se sumo al total dentro del carrito");
                    return;
                }
            }
            
            if (contador >= Items.Length)
            {
                AggItems = new Item[contador + 1];

                for (int i = 0; i < Items.Length; i++)
                {
                    AggItems[i] = Items[i];
                }

                Items = AggItems;
            }
            Items[contador] = item;
            contador++;
        }

        //Se hace uso de un nuevo vector 'RestItems' con una posicion menos que el original. Luego se hace nula la posicion del vector original 'Items' y se ordena de
        //manera que esta quede posicionada al final del vector y luego se extraen los valores al vector RestItems quedando fuera la posicion nula al final
        public void EliminarItem(int codigo)
        {
            int indice = -1;
            for (int i = 0; i < Items.Length; i++)
            {
                if (Items[i].GetCodigo() == codigo)
                {
                    indice = i;
                    break;
                }
            }

            // Eliminar Item del array y redimensionarlo 
            if (indice != -1)
            {
                Items[indice] = null;

                RestItems = new Item[Items.Length - 1];

                for (int i = indice; i < Items.Length - 1; i++)
                {
                    Items[i] = Items[i + 1];
                }
                for (int i = 0; i < RestItems.Length; i++)
                {
                    RestItems[i] = Items[i];
                }
                Items = RestItems;
                contador--;
                Console.WriteLine(Environment.NewLine + "Item eliminado del carrito" + Environment.NewLine);
            }
            else
            {
                Console.WriteLine("Item no encontrado en el carrito");
            }
        }

        public void ListarCarrito()
        {
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(Items[i].InfoItem());
            }
        }

        public int NumeroDeItems()
        {
            for (int i = 0; i < contador; i++)
            {
                numeroDeItems += Items[i].GetCantidad();
            }
            return numeroDeItems;
        }

        public double CalcularSubtotal()
        {
            for (int i = 0; i < contador; i++)
            {
                subtotal += (Items[i].GetSubprecio()) * (Items[i].GetCantidad());
            }

            return subtotal;
        }

        public double CalcularIva()
        {
            for (int i = 0; i < contador; i++)
            {
                iva += (Items[i].GetIva()) * (Items[i].GetCantidad());
            }

            return iva;
        }

        public double CalcularTotal()
        {
           double total = 0;

           for (int i = 0; i < contador; i++)
            {
                total += (Items[i].GetPrecio()) * (Items[i].GetCantidad());
            }

            return total;
        }
    }
    
}
