using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public Cliente(string nombre, int id, string email, string telefono, string direccion) : base(nombre, id)
        {
            this.email = email;
            this.telefono = telefono;
            this.direccion = direccion;
        }

        //Metodos
        public override void InfoPersona()
        {
            //Imprimir información del cliente
            
            Console.WriteLine("************Datos del Cliente************");
            base.InfoPersona();
            string info = $"Email:      {email}" + Environment.NewLine +
                          $"Telefono:   {telefono}" + Environment.NewLine +
                          $"Dirección:  {direccion}" + Environment.NewLine;
            Console.WriteLine(info);
        }
    }
}
