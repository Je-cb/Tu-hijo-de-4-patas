using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    internal class Vendedor : Persona
    {
        public int codigo;
        public Vendedor(string nombre, string apellido, int id, int codigo) : base(nombre, apellido, id)
        {
            this.codigo = codigo;
        }

        // Mostrar información
        public override void InfoPersona()
        {
            Console.WriteLine($"Información del Vendedor {codigo}");
            base.InfoPersona();
            string info = $"Código de vendedor: {codigo}" + Environment.NewLine;
            Console.WriteLine(info);
        }

        // Buscar vendedor por codigo
        public Vendedor BuscarVendedor(int codigoBuscar, Vendedor[] vendedores)
        {
            foreach (var vendedor in vendedores)
            {
                if (vendedor.codigo == codigoBuscar)
                {
                    return vendedor;
                }
            }
            return null;
        }
    }
}
