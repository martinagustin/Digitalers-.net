// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public struct Alumno
{
    //creamos y definimos nuestro propio tipo de dato
    public int Codigo;
    public string Nombre;
    public string Apellido;

    //creamos un metodo para realizar mostrar en pantalla la isncripcion
    public void MostrarDatos()
    {
        Console.WriteLine(Environment.NewLine + "Datos de inscripcion del alumno" + Environment.NewLine);

        Console.WriteLine($"Nombre:\n{Nombre}");
        Console.WriteLine($"Apellido:\n{Apellido}");

    }
}

namespace PruebaEstructuras
{
    public class Alumno
    {
        public Alumno()
        {
        }
    }
}