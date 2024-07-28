using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TuHijoDe4Patas
{
    internal class Vendedor : Persona
    {
        private int codigo;
        public Vendedor(string nombre, int id, int codigo) : base(nombre, id)
        {
            this.codigo = codigo;
        }

        public override void InfoPersona()
        {
            Console.WriteLine($"************Informacion del Vendedor {codigo}************");
            base.InfoPersona();
            string info = Environment.NewLine + $"Codigo de vendedor: {codigo}" + Environment.NewLine;
            Console.WriteLine(info);
        }
    }
}
