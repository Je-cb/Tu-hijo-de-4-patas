using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    internal class Cliente : Persona
    {
        private string email;
        private string telefono;
        private string direccion;
        public Cliente(string nombre, string apellido, int id, string email, string telefono, string direccion) : base(nombre, apellido, id)
        {
            this.email = email;
            this.telefono = telefono;
            this.direccion = direccion;
        }
        public override void InfoPersona()
        {
            base.InfoPersona();
            string info = $"Email: {email}" + Environment.NewLine +
                         $"Telefono: {telefono}" + Environment.NewLine +
                         $"Dirección: {direccion}" + Environment.NewLine;
            Console.WriteLine(info);
        }
    }
}
