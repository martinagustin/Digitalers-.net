using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practicando ADO .NET");
            SqlConnection con = new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VisualStudio\Digitalers\ADO-primeraparte\ConsoleApp1\Database1.mdf;Integrated Security=True");
            con.Open();
            //var comando = new SqlCommand("Select Count(*) from Persona",con);
            //string query = "Create table Producto(id int , Nombre varchar(50), Precio int);";
            //var comando = new SqlCommand(query,con);

            //var resultado=comando.ExecuteScalar();//devuelve 1er registro
            //Console.WriteLine(resultado);
            //var resultado =comando.ExecuteNonQuery();//orden no devuelve filas como resultado ejemplo create drop update
            string query = "Select * from Persona";
            var comando = new SqlCommand(query, con);
            var resultado = comando.ExecuteReader();
            Console.WriteLine("ID - Nombre - Apellido - Edad ",Environment.NewLine);
            while (resultado.Read())
            {
                Console.WriteLine($"{resultado[0]} - {resultado[1]} - {resultado[2]} - {resultado[3]}");
            }
            Console.ReadKey();

            con.Close();
        }
    }
}
