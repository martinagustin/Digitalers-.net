using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioObjetos
{
    public class Asistente :Persona
    {
        //public Persona DatosAsistente;
        public List<string> Tareas;
        public void mostrarTareas()
        {
            Console.WriteLine(Environment.NewLine,"Lista de tareas",Environment.NewLine);
            foreach(string item in Tareas)
            {
                Console.WriteLine(" - {0}",item);
            }
        }
         
    }
}
