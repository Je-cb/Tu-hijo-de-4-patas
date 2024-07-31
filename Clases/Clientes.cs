using System;

namespace TuHijoDe4Patas
{
    //Clase Cliente
    internal class Cliente : Persona
    {
        //Atributos
        private string email;
        private string telefono;
        private string direccion;

        //Constructor
        public Cliente(string nombre, string apellido, int id, string email, string telefono, string direccion) : base(nombre, apellido, id)
        {
            this.email = email;
            this.telefono = telefono;
            this.direccion = direccion;
        }

        //Metodos
        public override string InfoPersona()
        {
            //Ver información del cliente
            string mensaje = $" DATOS DEL CLIENTE " + Environment.NewLine +
                             base.InfoPersona() + Environment.NewLine +
                             $" Email:             {email}" + Environment.NewLine +
                             $" Teléfono:          {telefono}" + Environment.NewLine +
                             $" Dirección:         {direccion}" + Environment.NewLine;
            return mensaje;
        }
    }
}
