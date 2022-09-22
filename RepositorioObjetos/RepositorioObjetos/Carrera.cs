namespace RepositorioObjetos
{
    public class Carrera
    {
        public int Codigo;
        public string Nombre;
        public Materia[] Materias;

        public void mostrarMaterias()
        {
            foreach(Materia m in Materias)
            {
                System.Console.WriteLine("Codigo: {0}\tMateria: {1}",m.Codigo,m.Nombre);
            }
        }
    }
}