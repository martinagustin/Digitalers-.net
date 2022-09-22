using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m24_ej02
{
    public class Alumno
    {
        public string Nombre;
        public string Apellido;

        public Alumno(string nombre,string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        public Alumno()
        {
            Nombre = "desconocido";
        }
        public void mostrarDatos()
        {
            return "Nombre: " + Nombre + "\n" + "Apellido: " + Apellido;
        }
    }
}
