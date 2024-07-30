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

        public Mascota(string nombre, string tipo, string raza, int talla)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.raza = raza;

            switch (talla)
            {
                case 1:
                    this.talla = "Pequeño";
                    break;
                case 2:
                    this.talla = "Mediano";
                    break;
                case 3:
                    this.talla = "Grande";
                    break;
                default:
                    this.talla = "Mediano";         //Si se introduce una opcion invalida el constructor asigna a la talla el valor de 'Mediano' por defecto
                    break;
            }
        }

        public string InfoMascota()
        {

            string mensaje = $"*******************************************DATOS DE LA MASCOTA*******************************************" + Environment.NewLine +
                             $"Nombre:                  {nombre}" + Environment.NewLine +
                             $"Tipo:                    {tipo}" + Environment.NewLine +
                             $"Raza:                    {raza}" + Environment.NewLine +
                             $"Talla:                   {talla}" + Environment.NewLine;
            return mensaje;
        }
    }
}
