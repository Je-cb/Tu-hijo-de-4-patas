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
        private string nombre;
        private string apellido;
        private int id;

        //Metodos

        //Constructor parametrico
        public Persona(string nombre, string apellido, int id)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.id = id;
        }

        //Informacion del usuario
        public virtual void InfoPersona()
        {
            string info = $"********************INFORMACIÓN DE USUARIO***********************" + Environment.NewLine +
                          $"Nombre: {nombre}" + Environment.NewLine +
                          $"Apellido: {apellido}" + Environment.NewLine +
                          $"Número de identificación: {id}" + Environment.NewLine;

            Console.WriteLine(info);
        }
    }

    //Clase padre producto
    internal class Producto
    {
        //Atributos
        private int codigo;
        private string nombre;
        private string descripcion;
        private float precio;
        private string categoria;

    }
}
