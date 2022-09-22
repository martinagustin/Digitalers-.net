using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioObjetos
{
    public class Alumno :Persona
    {
        public Persona DatosAlumno;
        public Carrera carrera;
        
        public void mostrarDatos()
        {
            Console.WriteLine("Datos de la carrera del alumno" + Environment.NewLine);

            carrera.mostrarMaterias();
        }
        public void mostrarDatos(int paramEntero)
        {
            Console.WriteLine("Datos de la persona"+Environment.NewLine);
            Console.WriteLine("Codigo: {0}",DatosAlumno.getCodigo());
            Console.WriteLine("Nombre: {0}",DatosAlumno.Nombre);
            Console.WriteLine("Apellido: {0}", DatosAlumno.Apellido);

        }
        public void mostrarDatos(Boolean paramBool)
        {
            Console.WriteLine("Datos de contacto del alumno" + Environment.NewLine);

            Console.WriteLine("Telefono: {0}",DatosAlumno.Telefono);
            Console.WriteLine("Email: {0}",DatosAlumno.Email);

        }

    }
}
