using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TuHijoDe4Patas
{
    internal class Cama : Item
    {
        //Atributos
        private string diseñoPersonalizado;

        //Constructor
        public Cama(string diseñoPersonalizado, int codigo, string nombre, string descripcion, double subprecio, string categoria, Mascota mascota) : base(codigo, nombre, descripcion, subprecio, categoria)// Llamada al constructor de la clase Item
        {
            this.diseñoPersonalizado = diseñoPersonalizado;

        }

    }
}
