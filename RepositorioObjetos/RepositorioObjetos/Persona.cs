using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioObjetos
{
    public abstract class Persona
    {
        private int Codigo;
        public string Nombre;
        public string Apellido;
        public string Email;
        public string Telefono;

        public void setCodigo(int paramCodigo)
        {
            Codigo = paramCodigo;
        }
        public int getCodigo()
        {
            return Codigo;
        }
        public string verDatos()
        {
            return Codigo + " - " + Nombre + " - " + Apellido;
        }
        public virtual void mostrarDatos()
        {
            //Console.WriteLine("Datos del alumno"+Environment.NewLine);
            Console.WriteLine("Codigo: {0}",Codigo);
            Console.WriteLine("Nombre: {0}",Nombre);
            Console.WriteLine("Apellido: {0}", Apellido);

        }
        
    }
}

