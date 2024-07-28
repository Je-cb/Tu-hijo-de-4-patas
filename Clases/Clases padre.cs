using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TuHijoDe4Patas
{
    //Clase padre persona
    internal class Persona
    {
        //Atributos
        private string nombre;
        private int id;

        //Metodos
        //Constructor parametrico
        public Persona(string nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
        }

        //Informacion del usuario
        public virtual void InfoPersona()
        {
            string info = $"Nombre:                     {nombre}" + Environment.NewLine +
                          $"Número de identificación:   {id}";

            Console.WriteLine(info);
        }
    }

    //Clase padre producto
    internal class Producto
    {
        //Atributos
        private int codigo;
        private string nombre;
        private string descripcion;
        private double precio;
        private string categoria;

        //Constructor parametrico
        public Producto(int codigo, string nombre, string descripcion, double precio, string categoria)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.categoria = categoria;
        }

        //Informacion del producto
        public virtual void InfoProducto()
        {
            string mensaje = $"************INFORMACIÓN DEL PRODUCTO************" + Environment.NewLine +
                             $"Codigo:                  {codigo}" + Environment.NewLine +
                             $"Nombre:                  {nombre}" + Environment.NewLine + 
                             $"Descripción:             {descripcion}" + Environment.NewLine + 
                             $"Precio:                  {precio}" + Environment.NewLine + 
                             $"Categoria de producto:   {categoria}";
            Console.WriteLine(mensaje);
        }

        //Retorna codigo del producto
        public int GetCodigo()
        { 
            return codigo;
        }

        //Retorna precio del producto
        public double GetPrecio()
        {
            return precio;
        }
    }
}
