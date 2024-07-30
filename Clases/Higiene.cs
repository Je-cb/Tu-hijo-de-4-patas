using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TuHijoDe4Patas
{
    internal class Higiene : Item
    {
        //Atributos
        private int tipo; //1 - Cepillo | 2 - Cortauñas | 3 - Kit de Aseo

        //Constructor
        public Higiene(int codigo, string nombre, string descripcion, double subprecio, string categoria, int tipo, Mascota mascota) : base(codigo, nombre, descripcion, subprecio, categoria)// Llamada al constructor de la clase Item
        {
            this.tipo = tipo;
        }


    }
}
