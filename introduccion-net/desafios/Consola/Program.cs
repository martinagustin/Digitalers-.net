using desafios;
Console.WriteLine("Hello, World!");
crearAlumno();
static void crearAlumno()
{
    Console.Clear();
    Console.ReadKey();
    Alumno a = new Alumno("Juan", "Perez");
    a.mostrarDatos();
}