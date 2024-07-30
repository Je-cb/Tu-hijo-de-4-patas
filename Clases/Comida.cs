using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TuHijoDe4Patas
{
    internal class ComidaPersonalizada : Item
    {
        
        //Atributos
        private string necesidades;

        public ComidaPersonalizada(int codigo, string nombre, string descripcion, double subprecio, string categoria, string necesidades, Mascota mascota) : base(codigo, nombre, descripcion, subprecio, categoria)// Llamada al constructor de la clase Item
        {
            this.necesidades = necesidades;
        }

    }
}
