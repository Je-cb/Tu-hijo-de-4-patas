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
        private bool contribuyenteEsp;

        //Constructor
        public Cliente(string nombre, string apellido, int id, string email, string telefono, string direccion, int contribuyente) : base(nombre, apellido, id)
        {
            this.email = email;
            this.telefono = telefono;
            this.direccion = direccion;

            if (contribuyente == 1 | contribuyente == 0)    // 1 - ES CONTRIBUYENTE ESPECIAL / 0 - NO ES CONTRIBUYENTE ESPECIAL
            {
                contribuyenteEsp = Convert.ToBoolean(contribuyente);
            }
            else
            {
                contribuyenteEsp = false;
            }
            
        }

        //Metodos
        //Ver información del cliente
        public override string InfoPersona()
        {
            
            string contribuyenteATexto;

            if (contribuyenteEsp)
            {
                contribuyenteATexto = "SI";
            }
            else
            {
                contribuyenteATexto = "NO";
            }

            string mensaje = $" DATOS DEL CLIENTE " + Environment.NewLine +
                             base.InfoPersona() + Environment.NewLine +
                             $" Email:                  {email}" + Environment.NewLine +
                             $" Teléfono:               {telefono}" + Environment.NewLine +
                             $" Dirección:              {direccion}" + Environment.NewLine +
                             $" Contribuyente especial: {contribuyenteATexto}";
            return mensaje;
        }

        //Retorna tipo de contribuyente
        public bool TipoContribuyente()
        {
            return contribuyenteEsp;
        }
    }
}
