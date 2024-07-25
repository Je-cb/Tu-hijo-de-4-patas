using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    internal class Vendedor : Persona
    {
        private int codigo;
        public Vendedor(string nombre, string apellido, int id, int codigo) : base(nombre, apellido, id)
        {
            this.codigo = codigo;
        }

        public override void InfoPersona()
        {
            Console.WriteLine($"Informacion del Vendedor {codigo}");
            base.InfoPersona();
            string info = $"Codigo de vendedor: {codigo}" + Environment.NewLine;
            Console.WriteLine(info);
        }
    }
}
