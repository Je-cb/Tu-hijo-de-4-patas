using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TuHijoDe4Patas
{
    internal class Producto : Item
    {
        //Atributos
        private string necesidades;             //Necesidades particulares de la mascota para cada producto -- Escribir 'NO APLICA' cuando sea necesario
        private string tipo;                    //Tipo de producto de acuerdo a las necesidades de la mascota -- Escribir 'NO APLICA' cuando sea necesario
        private string diseñoPersonalizado;     //Diseño personalizado para el producto -- Escribir 'NO APLICA' cuando sea necesario
        private string caracteristicas;         //Caracteristicas particulares de acuerdo al tipo de animal -- Escribir 'NO APLICA' cuando sea necesario

        //Constructor con parametros completos
        public Producto(int codigo, string nombre, string descripcion, double subprecio, string categoria, Mascota mascota, Cliente cliente, string necesidades, string tipo, string diseñoPersonalizado, string caracteristicas) : base(codigo, nombre, descripcion, subprecio, categoria)
        {
            this.necesidades = necesidades;
            this.tipo = tipo;
            this.diseñoPersonalizado = diseñoPersonalizado;
            this.caracteristicas = caracteristicas;
        }

        //Constructor con atributos esenciales para creacion inicial
        public Producto(int codigo, string nombre, string descripcion, double subprecio, string categoria) : base(codigo, nombre, descripcion, subprecio, categoria)
        {
            necesidades = tipo = diseñoPersonalizado = caracteristicas = "Personalizado de acuerdo a las necesidades de la mascota y a las preferencias del dueño";
        }

        //Setters para atributos
        public void SetNecesidades(string necesidades)
        {
            this.necesidades = necesidades;
        }

        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public void SetDiseñoP(string diseñoPersonalizado)
        {
            this.diseñoPersonalizado = diseñoPersonalizado;
        }

        public void SetCaracteristicas(string caracteristicas)
        {
            this.caracteristicas = caracteristicas;
        }

        //Ver informacion de producto
        public override string InfoItem()
        {
            string mensaje = base.InfoItem() + Environment.NewLine +
                             $"Necesidades particulares de producto:       {necesidades}" + Environment.NewLine +
                             $"Tipo de producto:                           {tipo}" + Environment.NewLine +
                             $"Diseño personalizado:                       {diseñoPersonalizado}" + Environment.NewLine +
                             $"Caracteristicas particulares de producto    {caracteristicas}";
            return mensaje;
        }

    }
}
