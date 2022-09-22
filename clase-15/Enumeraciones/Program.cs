// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
static void InscripcionVariables()
{
Console.WriteLine("-----------------------DATOS ALUMNO--------------------");
Console.WriteLine("Ingrese nombre");
String nombre = Console.ReadLine();
Console.WriteLine("Ingrese apellido");
String apellido = Console.ReadLine();
Console.WriteLine("Ingrese turno");
string turno = Console.ReadLine();
TURNO valor=TURNO.Manana;
switch (turno.ToUpper())
{
    case "MANANA":
        valor = TURNO.Manana;
        break;
    case "TARDE":
        valor = TURNO.Tarde;
        break;
    case "NOCHE":
        valor = TURNO.Noche;
        break;
}
Console.WriteLine("datos de la inscripcion" + Environment.NewLine);
Console.WriteLine($"Nombre: {nombre}\nApellido: {apellido}\nTurno:{turno}");

}
enum TURNO { Manana, Tarde, Noche }
