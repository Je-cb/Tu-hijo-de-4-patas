using System;

namespace TuHijoDe4Patas
{
    internal class Vendedor : Persona
    {
        public int codigo;
        public Vendedor(string nombre, string apellido, int id, int codigo) : base(nombre, apellido, id)
        {
            this.codigo = codigo;
        }

        // Mostrar información
        public override string InfoPersona()
        {

            string mensaje = $" Información del Vendedor {codigo} " + Environment.NewLine +
                            base.InfoPersona() + Environment.NewLine +
                            $" Codigo del vendedor:             {codigo}" + Environment.NewLine;
            return mensaje;
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
