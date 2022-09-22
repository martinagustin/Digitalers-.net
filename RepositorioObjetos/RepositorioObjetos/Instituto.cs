using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioObjetos
{
    public static class Instituto
    {
        public static string Nombre = "Educacion IT";
        public static string Direccion = "Lavalle 655";
        public static string Web = "https://www.educacionit.com";
        public static void mostrarInstituto()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Direccion: {Direccion}");
            Console.WriteLine($"Sitio web: {Web}");
        }
    }
}
