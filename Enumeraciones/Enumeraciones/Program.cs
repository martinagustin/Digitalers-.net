
//InscripcionVariable();
InscripcionEstructuras();
static void InscripcionHardcode()
{
    Console.WriteLine("Datos de inscripcion del alumno"+Environment.NewLine);
    Console.WriteLine("Nombre:Ariel");
    Console.WriteLine("Apellido: Mercado F.");
    Console.WriteLine("Mail: amercado@gmail.com");
    Console.WriteLine("Curso: Developer.Net");
    Console.WriteLine("Turno: {0}",Turno.Night);
}
static void InscripcionVariable()
{
    Console.WriteLine("Ingrese datos de inscripcion");
    Console.WriteLine("Nombre:");
    string nombre = Console.ReadLine();
    Console.WriteLine("apellido");
    string apellido = Console.ReadLine();
    Console.WriteLine("Mail:");
    string mail = Console.ReadLine();
    Console.WriteLine("Curso:");
    string curso = Console.ReadLine();
    Console.WriteLine("Turno:");
    string turno = Console.ReadLine();

    Turno valor=Turno.Morning;
    switch (turno.ToUpper())
    {
        case ("MORNING"):
            valor= Turno.Morning;
            break;
        case ("AFTERNOON"):
            valor= Turno.Afternoon;
            break;
        case ("NIGHT"):
            valor = Turno.Night;
            break;
    }

    Console.WriteLine(Environment.NewLine+"Datos de inscripcion del alumno" + Environment.NewLine);
    Console.WriteLine($"Nombre:{nombre}");
    Console.WriteLine($"Apellido:{apellido}");
    Console.WriteLine($"Mail:{mail}");
    Console.WriteLine($"Curso:{curso}");
    Console.WriteLine($"Turno: {valor}");
}
static void InscripcionEstructuras()
{
    Inscripcion i = new Inscripcion() ;

    Console.WriteLine("Ingrese datos de inscripcion");
    Console.WriteLine("Nombre:");
    i.Nombre = Console.ReadLine();
    Console.WriteLine("apellido");
    i.Apellido = Console.ReadLine();
    Console.WriteLine("Mail:");
    i.Mail = Console.ReadLine();
    Console.WriteLine("modalidad de Actividad:");
    string modalidad = Console.ReadLine();

    Console.WriteLine("nombre de Actividad:");
    string NombreActividad= Console.ReadLine();

    Console.WriteLine("Turno:");
    string turno = Console.ReadLine();

    i.Actividad = Actividad.Curso;
    i.Turno =Turno.Morning;
    i.Modalidad = Modalidad.Presencial;

    switch (turno.ToUpper())
    {
        case ("MORNING"):
            i.Turno = Turno.Morning;
            break;
        case ("AFTERNOON"):
            i.Turno = Turno.Afternoon;
            break;
        case ("NIGHT"):
            i.Turno = Turno.Night;
            break;
    }
    switch (NombreActividad.ToUpper())
    {
        case ("CURSO"):
            i.Actividad = Actividad.Curso;
            break;
        case ("CARRERA"):
            i.Actividad=Actividad.Carrera;
            break;
        case ("WEBINAR"):
            i.Actividad = Actividad.Webinar;
            break;
        case ("BOOTCAMP"):
            i.Actividad = Actividad.Bootcamp;
            break;
    }
    i.Modalidad = Modalidad.Online;

    //inscripcion cargada manual
    i.MostrarDatos();
    //inscripcion hardocode
    
    Inscripcion i1=new Inscripcion();
    i1.Nombre = "Juan";
    i1.Apellido = "Perez";
    i1.Mail = "Holamundo@gmail.com";
    i1.Modalidad = Modalidad.Presencial;
    i1.Actividad = Actividad.Webinar;
    i1.Turno = Turno.Afternoon;
    Console.WriteLine("------------------");
    i1.MostrarDatos();

    Inscripcion[] inscripciones = new Inscripcion[2];
    inscripciones[0] = i;
    inscripciones[1] = i1;

    Console.WriteLine(Environment.NewLine+"Alumnos inscriptos"+Environment.NewLine);
    foreach(Inscripcion alumno in inscripciones)
    {
        Console.WriteLine("Nombre: {0} - Apellido: {1}",alumno.Nombre,alumno.Apellido);
    }
}

public struct Inscripcion
{
    //creamos y definimos nuestro propio tipo de dato
    public int Codigo;
    public string Nombre;
    public string Apellido;
    public string Mail;
    public Actividad Actividad;
    public string NombreActividad;
    public Turno Turno;
    public Modalidad Modalidad;

    //creamos un metodo para realizar mostrar en pantalla la isncripcion
    public void MostrarDatos()
    {
        Console.WriteLine(Environment.NewLine + "Datos de inscripcion del alumno" + Environment.NewLine);

        Console.WriteLine($"Nombre:\n{Nombre}");
        Console.WriteLine($"Apellido:\n{Apellido}");
        Console.WriteLine($"Mail:\t{Mail}");
        Console.WriteLine($"modalidad:\n{Modalidad}");
        Console.WriteLine($"actividad:\n{Actividad}");
        Console.WriteLine($"Turno:\n{Turno}");

    }
}
enum Turno { Morning,Afternoon,Night};
enum Modalidad { Online=10, Presencial };
enum Actividad { Curso=100, Carrera=200, Webinar= 300, Bootcamp=400 };
