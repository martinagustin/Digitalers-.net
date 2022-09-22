using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RepositorioObjetos
{
    public class Materia
    {
        public int Codigo;
        public string Nombre;
        public int clases;
        public DateTime HoraInicioClases;
        public DateTime HoraFinClases;

        public Materia(int codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }

        public Materia()
        {
        }
        //(horainicio-horafinal)*clases=duracion de la materia.

    }
}