using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    //Clase padre persona
    internal class Persona
    {
        //Atributos
        private string Nombre;
        private string Apellido;
        private int ID;

        //Metodos

        //Constructor parametrico
        public Persona(string Nombre, string Apellido, int ID)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.ID = ID;
        }

        //Informacion del usuario
        public void InfoPersona()
        {
            string info = $"********************INFORMACIÓN DE USUARIO***********************" + Environment.NewLine +
                          $"Nombre: {Nombre}" + Environment.NewLine +
                          $"Apellido: {Apellido}" + Environment.NewLine +
                          $"Número de identificación: {ID}" + Environment.NewLine;

            Console.WriteLine(info);
        }
    }

    //Clase padre producto
    internal class Producto
    {
        //Atributos
        private int Codigo;
        private string Nombre;
        private string Descripcion;
        private float Precio;
        private string Categoria;

    }
}
