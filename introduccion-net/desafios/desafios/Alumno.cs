using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafios
{
    public class Alumno
    {
        public string Nombre;
        public string Apellido;

        public Alumno(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        public void mostrarDatos()
        {
            Console.WriteLine("--------------",Environment.NewLine);
            Console.WriteLine("Nombre: {0}",Nombre,Environment.NewLine);
            Console.WriteLine("Apellido: {0}",Apellido,Environment.NewLine);
        }
    }
}
