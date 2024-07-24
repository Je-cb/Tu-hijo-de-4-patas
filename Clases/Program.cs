using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte los datos del usuario:" + Environment.NewLine + "Nombre:" + Environment.NewLine);

            string Nombre = Console.ReadLine();

            Console.WriteLine("Apellido:" + Environment.NewLine);

            string Apellido = Console.ReadLine();

            Console.WriteLine("Numero de identificacion" + Environment.NewLine);

            int ID = Convert.ToInt32(Console.ReadLine());

            Persona persona1 = new Persona(Nombre, Apellido, ID);

            persona1.InfoPersona();

            Console.ReadLine();

            /*Console.WriteLine("Mostrar datos del usuario? (1 - SI / 2 - NO)" + Environment.NewLine);
            int choice = Console.Read();

            if (choice == 1)
            {
                
            }*/
        }
    }
}
