﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TuHijoDe4Patas
{
    internal class Collar : Item
    {
        public Collar(int codigo, string nombre, string descripcion, double subprecio, string categoria, Mascota mascota, Persona cliente) : base(codigo, nombre, descripcion, subprecio, categoria)
        {
            
        }
    }
}
