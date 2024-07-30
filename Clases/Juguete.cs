using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TuHijoDe4Patas
{
    internal class Juguete : Item
    {
        //Atributos
        private string diseñoPersonalizado;
        private string caracteristicas;

        public Juguete(int codigo, string nombre, string descripcion, double subprecio, string categoria, string diseñoPersonalizado, string caracteristicas, Mascota mascota) : base(codigo, nombre, descripcion, subprecio, categoria)// Llamada al constructor de la clase Item
        {
            this.diseñoPersonalizado = diseñoPersonalizado;
            this.caracteristicas = caracteristicas;

        }

    }
}
