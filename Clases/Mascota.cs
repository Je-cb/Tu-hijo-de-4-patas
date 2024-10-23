using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TuHijoDe4Patas
{
    internal class Mascota
    {
        private string nombre;
        private string tipo;        //Gato, perro, loro, etc
        private string raza;        //Escribir NO APLICA si es necesario
        private string talla;       // 1 - Pequeño | 2 - Mediano | 3 - Grande
        private int edad;

        public Mascota(string nombre, string tipo, string raza, string talla, int edad)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.raza = raza;
            this.talla = talla;
            this.edad = edad;
        }

        public string InfoMascota()
        {

            string mensaje = $"*******************************************DATOS DE LA MASCOTA*******************************************" + Environment.NewLine +
                             $"Nombre:                  {nombre}" + Environment.NewLine +
                             $"Tipo:                    {tipo}" + Environment.NewLine +
                             $"Raza:                    {raza}" + Environment.NewLine +
                             $"Tamaño:                  {talla}" + Environment.NewLine + Environment.NewLine +
                             $"Edad:                    {edad}" + Environment.NewLine;
            return mensaje;
        }
    }
}
