// See https://aka.ms/new-console-template for more information
using RepositorioObjetos;

//CrearAlumno2();
CrearProfesor();
//CrearAsistente();
static void CrearAlumno()
{
    Alumno a = new Alumno();

    Console.WriteLine("Ingrese codigo");
    //a.Codigo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese nombre");
    //a.Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese apellido",Environment.NewLine);
    //a.Apellido = Console.ReadLine();

    //a.mostrarDatos();

}

static void CrearAlumno2()
{
    Alumno a = new Alumno();
    Console.WriteLine("Indique codigo");
    //p.Codigo = Convert.ToInt32(Console.ReadLine());
    a.setCodigo(Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine("Ingrese nombre Alumno");
    a.Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese apellido");
    a.Apellido=Console.ReadLine();
    Console.WriteLine("Ingrese telefono");
    a.Telefono=Console.ReadLine();
    Console.WriteLine("Ingrese email");
    a.Email=Console.ReadLine();

    
    //aqui se realiza la contension
    Console.WriteLine(a.verDatos());
    Console.Clear();

    Materia[] array_materias = new Materia[3];
    Materia m1 = new Materia(1001,"HTML5");
    Materia m2 = new Materia(1002, "Javascript incial");
    Materia m3 = new Materia(1003, "Introduccion a BBDD y SQL");

    array_materias[0] = m1;
    array_materias[1] = m2;
    array_materias[2] = m3;


    Carrera c = new Carrera();
    c.Codigo = 100;
    c.Nombre = "Telecom Digi@lers Developer .Net";
    c.Materias = array_materias;

    a.carrera = c;
    //a.mostrarCarrera();
    a.mostrarDatos();
    Console.ReadKey();
    Console.Clear();
    a.mostrarDatos(1);
    Console.ReadKey();
    Console.Clear();
    a.mostrarDatos(true);
    Console.ReadKey();
    Console.Clear();

}

static void CrearProfesor()
{
    Profesor p = new Profesor();


    Console.WriteLine("Indique codigo del profesor");
    //p.Codigo = Convert.ToInt32(Console.ReadLine());
    p.setCodigo(Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine("Ingrese nombre del profesor");
    p.Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese apellido del profesor");
    p.Apellido = Console.ReadLine();
    Console.WriteLine("Ingrese telefono del profesor");
    p.Telefono = Console.ReadLine();
    Console.WriteLine("Ingrese correo del profesor");
    p.Email = Console.ReadLine();
    Console.WriteLine("Ingrese titulo");
    p.Titulo = Console.ReadLine();

    p.mostrarDatos();

    Console.ReadKey();
}

static void CrearAsistente()
{
    Asistente a = new Asistente();


    Console.WriteLine("Indique codigo del asistente");
    //p.Codigo = Convert.ToInt32(Console.ReadLine());
    a.setCodigo(Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine("Ingrese nombre del asistente");
    a.Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese apellido del asistente");
    a.Apellido = Console.ReadLine();
    Console.WriteLine("Ingrese telefono del asistente");
    a.Telefono = Console.ReadLine();
    Console.WriteLine("Ingrese correo del asistente");
    a.Email = Console.ReadLine();

    List<string> lista_tareas = new List<string>();
    lista_tareas.Add("Habilitar clase");
    lista_tareas.Add("Enviar invitaciones");
    lista_tareas.Add("Registrar asistencia");
    lista_tareas.Add("Grabar, cerrar y subir la clase");

    a.Tareas = lista_tareas;


    a.mostrarDatos();
    a.mostrarTareas();

    Console.ReadKey();
}
