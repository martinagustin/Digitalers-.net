using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioObjetos
{
    public class Profesor :Persona
    {
        //public Persona DatosProfesor;
        public string Titulo;
        public DateTime InicioDocencia;

        public override void mostrarDatos()
        {
            Console.WriteLine(Environment.NewLine,"Datos del profeosor",Environment.NewLine);
            Console.WriteLine("-------------------",Environment.NewLine);
            base.mostrarDatos();
            Console.WriteLine($"Codigo: {getCodigo()} - Nombre: {Nombre} - Apellido {Apellido} ");
            Console.WriteLine("Titulo: {0}",Titulo);
            Console.WriteLine("Fecha de inicio: {0}",InicioDocencia);
        }

        public Profesor(string pNombre, string pApellido)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
        }

        public Profesor(string pNombre,string pApellido , string pTitulo)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Titulo = pTitulo;
        }

    }

}
