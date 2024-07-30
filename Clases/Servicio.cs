using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TuHijoDe4Patas
{
    internal class Servicio : Item
    {
        private DateTime fechaCita;     //Fecha y hora de la cita del servicio
        private TimeSpan duracionServ;  //Duracion de tiempo para servicios de hospedaje

        public Servicio(int codigo, string nombre, string descripcion, double subprecio, string categoria, Mascota mascota, Persona cliente, DateTime fechaCita, TimeSpan duracionServ) : base(codigo, nombre, descripcion, subprecio, categoria)
        {
            this.fechaCita = fechaCita;
            this.duracionServ = duracionServ;
        }

    }
}
