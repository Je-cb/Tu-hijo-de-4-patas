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

        public Producto(int codigo, string nombre, string descripcion, double subprecio, string categoria, Mascota mascota, Persona cliente, string necesidades, string tipo, string diseñoPersonalizado, string caracteristicas) : base(codigo, nombre, descripcion, subprecio, categoria)
        {
            this.necesidades = necesidades;
            this.tipo = tipo;
            this.diseñoPersonalizado = diseñoPersonalizado;
            this.caracteristicas = caracteristicas;
        }

    }
}
