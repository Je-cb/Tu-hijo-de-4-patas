using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace TuHijoDe4Patas
{
    internal class Servicio : Item
    {
        private DateTime fechaCita;     //Fecha y hora de la cita del servicio
        private TimeSpan duracionServ;  //Duracion de tiempo para servicios de hospedaje

        //Constructor con parametros completos
        public Servicio(int codigo, string nombre, string descripcion, double subprecio, string categoria, Mascota mascota, Persona cliente, DateTime fechaCita, TimeSpan duracionServ) : base(codigo, nombre, descripcion, subprecio, categoria)
        {
            this.fechaCita = fechaCita;
            this.duracionServ = duracionServ;
        }

        //Constructor con atributos esenciales para creacion inicial
        public Servicio(int codigo, string nombre, string descripcion, double subprecio, string categoria) : base(codigo, nombre, descripcion, subprecio, categoria)
        {

        }

        //Setters para atributos
        public void SetFecha(DateTime fechaCita)
        {
            this.fechaCita = fechaCita;
        }

        public void SetDuracion(TimeSpan duracionServ)
        {
            this.duracionServ = duracionServ;
        }

        //Ver informacion del servicio
        public override string InfoItem()
        {
            string mensaje = base.InfoItem() + Environment.NewLine +
                             $"Fecha de cita:       {fechaCita}" + Environment.NewLine +
                             $"Duracion:            {duracionServ}";
            return mensaje;
        }

    }
}
