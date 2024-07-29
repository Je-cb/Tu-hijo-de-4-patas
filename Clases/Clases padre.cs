using System;
using System.Security.Permissions;

namespace TuHijoDe4Patas
{
    //Clase padre persona
    internal class Persona
    {
        //Atributos
        private string nombre;
        private string apellido;
        private int id;

        //Metodos
        //Constructor parametrico
        public Persona(string nombre, string persona, int id)
        {
            this.nombre = nombre;
            this.id = id;
        }

        //Informacion del usuario
        public virtual void InfoPersona()
        {
            string info = $" Nombre: {nombre}" + Environment.NewLine +
                          $" Apellido: {apellido}" + Environment.NewLine +
                          $" Número de identificación: {id}";

            Console.WriteLine(info);
        }
    }

    //Clase padre Item
    internal class Item
    {
        //Atributos
        private int codigo;
        private string nombre;
        private string descripcion;
        private double subprecio;           //Precio del item sin IVA
        private double iva;                 //IVA del item de acuerdo a su precio
        private double precio;              //Precio final del item con IVA
        private string categoria;
        private int cantidad;

        //Constructor parametrico
        public Item(int codigo, string nombre, string descripcion, double subprecio, string categoria)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.subprecio = subprecio;     //El constructor recibe inicialmente el precio del item sin iva y en base a esto automaticamente calcula el iva y el precio final de venta. Se hace para facilitar la finalizacion de la factura
            this.categoria = categoria;
            iva = this.subprecio * 0.16;
            precio = this.subprecio + iva;
            cantidad = 1;
        }

        //Informacion del Item
        public virtual void InfoItem()
        {
            string mensaje = $"Codigo:                  {codigo}" + Environment.NewLine +
                             $"Nombre:                  {nombre}" + Environment.NewLine + 
                             $"Descripción:             {descripcion}" + Environment.NewLine + 
                             $"Precio sin iva:          {subprecio} x {cantidad} = {subprecio*cantidad}" + Environment.NewLine + 
                             $"Categoria de Item:       {categoria}";
            Console.WriteLine(mensaje);
        }

        //Retorna codigo del Item
        public int GetCodigo()
        { 
            return codigo;
        }

        public double GetSubprecio()
        {
            return subprecio;
        }

        public double GetIva()
        {
            return iva;
        }

        //Retorna precio del Item
        public double GetPrecio()
        {
            return precio;
        }

        public int GetCantidad()
        {
            return cantidad;
        }

        public void SetCantidad()
        {
            cantidad++;
        }
    }
}
